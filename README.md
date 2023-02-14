
# BackupOracleTables

## Description

Backup all tables from an oracle database to .xlsx-files in a local folder. This tool can be usefull if you want to do a local backup from all tables of a database or you just want to have all tables in a local directory.

## Usage

Start program, it will look  like this:

![program-on-start](https://raw.githubusercontent.com/mauricepreiss/mauricepreiss/main/oraclebackup-program-start.png)

- Textbox: Path
    - The path where all your files will be saved
- Button: Clear Path:
    - The little button with the trash bin on it lets you delete the path from textbox and from settings
- Button: Settings
    - Here you add your Oracle connection data and the question, if you wanna backup instantly when program starts
- Button: Select path and set:
    - Opens folder dialog to let you select a path for you files, after clicking OK the path will be stored in textbox and in settings
- Button: Save tables
    - Saves the tables from in settings given database and saves all its tables to your selected path. A splash loading window will show you that it's in progress.

### Settings
As already sayed above, in the settings window you will manage your Oracle connection data.

![settings](https://raw.githubusercontent.com/mauricepreiss/mauricepreiss/main/oraclebackup-settings.png)

- Textbox: Host
    - Hostname for your connection
- Textbox: Port
    - Port for your connection
- Textbox: Servicename
    - Servicename for your connection
- Textbox: Username
    - Username for your connection
- Textbox: Password
    - Password for your connection

❗NOTE: The password will be stored encrypted in settings, so its not possible to steal without the program itself. ❗

- Button: Check Connection
    - Before you can set connection, you have to test if all connection data is valid and a connection could be established. When connection with given connection data is successfull, you can click the "Set Connection" button and the connection will be set.
- Checkbox: Save on program start
    - If you dont want to press the "Save" button anytime, you can tick this little box. It allows you to backup tables directly on program start.


## License

- no copyright
- free for commertical usage

## Author ✍️

[@mauricepreiss](https://www.github.com/mauricepreiss)
