using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BackupOracleTables.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BackupOracleTables.Classes
{
    public static class Database
    {
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private static string host = Properties.Settings.Default.host;
        private static string servicename = Properties.Settings.Default.servicename;
        private static string port = Properties.Settings.Default.port;
        private static string userid = Properties.Settings.Default.username;
        private static string password = Properties.Settings.Default.password;

        private static string decryptedpassword = Common.DecryptText(password);

        static string connectionString = $"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = {host})(PORT = {port}))(CONNECT_DATA = (SERVICE_NAME = {servicename})));User Id={userid};Password={decryptedpassword};persist security info = true";

        public static bool BackupTables(string savePath)
        {
            // today date as iso date
            string today = DateTime.Now.ToString("yyyyMMdd");

            // list with all tablenames
            List<string> tables = new List<string>();

            // list with already used table names
            List<string> usedtables = new List<string>();

            // new excel application
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = null;
            Microsoft.Office.Interop.Excel.Worksheet sheet = null;
            var workbooks = excel.Workbooks;

            // start new loading form
            Thread thread = new Thread(StartForm);
            thread.Start();

            try
            {
                using (OracleConnection connection = new OracleConnection(connectionString))
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("SELECT TABLE_NAME FROM ALL_TABLES", connection))
                    {
                        using (OracleDataAdapter da = new OracleDataAdapter(cmd)) // get all table names
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt); // Adapter füllen
                            foreach (DataRow row in dt.Rows) // go through every line
                            {
                                tables.Add(row[0].ToString()); // add table name to list
                            }

                            foreach (string table in tables) // go through every table name in list
                            {
                                using (OracleCommand backup_cmd = new OracleCommand($"SELECT * FROM {table}", connection))
                                {
                                    using (OracleDataReader reader = backup_cmd.ExecuteReader())
                                    {
                                        // fill datatable
                                        DataTable temptable = new DataTable();
                                        OracleDataAdapter da2 = new OracleDataAdapter(backup_cmd);
                                        da2.Fill(temptable);

                                        // set paths
                                        string foldername = savePath + $@"\{today}";
                                        string filename = savePath + $@"\{today}\{table}.xlsx";

                                        if (!Directory.Exists(foldername))
                                        {
                                            Directory.CreateDirectory(foldername);
                                        }

                                        // unvisible excel app
                                        excel.Visible = false;

                                        // disable display alters
                                        excel.DisplayAlerts = false;

                                        // create workboot
                                        workbook = excel.Workbooks.Add(Type.Missing);

                                        // set sheet and rename
                                        sheet = workbook.ActiveSheet;
                                        sheet.Name = table;

                                        // insert header
                                        for (int i = 1; i < temptable.Columns.Count; i++)
                                        {
                                            sheet.Cells[1, i] = temptable.Columns[i - 1].ColumnName;
                                        }

                                        // add rows and columns
                                        for (int i = 0; i < temptable.Rows.Count; i++)
                                        {
                                            for (int j = 0; j < temptable.Columns.Count; j++)
                                            {
                                                sheet.Cells[i + 2, j + 1] = temptable.Rows[i][j].ToString();
                                            }
                                        }

                                        workbook.SaveAs(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                                        workbook.Close();
                                        usedtables.Add(table);
                                    }
                                }

                            }

                            // open folder
                            Process.Start(savePath + $@"\{today}");

                            // close thread with loading window
                            thread.Abort();

                            // close excel application with process id
                            int hWnd = excel.Application.Hwnd;
                            uint processID;

                            GetWindowThreadProcessId((IntPtr)hWnd, out processID);
                            Process.GetProcessById((int)processID).Kill();

                            workbook = null;
                            sheet = null;
                            excel = null;

                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                workbooks.Close();
                excel.Quit();
                return false;
            }
        }

        public static bool CheckForConnection(string host, string port, string servicename, string username, string password)
        {
            try
            {
                string ConconnectionString = $"Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = {host})(PORT = {port}))(CONNECT_DATA = (SERVICE_NAME = {servicename})));User Id={username};Password={password};persist security info = true";
                using (OracleConnection connection = new OracleConnection(ConconnectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        // start wait form
        private static void StartForm()
        {
            var waitform = new WaitForm();
            waitform.ShowDialog();
        }
    }
}
