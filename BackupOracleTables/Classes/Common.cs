using System;
using System.Text;
using System.Security.Cryptography;

namespace BackupOracleTables.Classes
{
    public static class Common
    {
        private static string hash = "ORaCleBaCkUp2022?="; // CHANGE HASH IF YOU WANT TO

        public static string EncryptText(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(Text);
                using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
                {
                    byte[] keys = provider.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return Convert.ToBase64String(result, 0, result.Length);
                    }
                }
            }
            return string.Empty;
        }

        public static string DecryptText(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                byte[] data = Convert.FromBase64String(Text);
                using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
                {
                    byte[] keys = provider.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] result = transform.TransformFinalBlock(data, 0, data.Length);
                        return UTF32Encoding.UTF8.GetString(result);
                    }
                }
            }

            return string.Empty;
        }
    }
}
