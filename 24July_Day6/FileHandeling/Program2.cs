using System.IO;
class FileOperations
{
    static void Main()
    {
        string logfile = "logs.txt";
        string backupFile = "logs_backup.txt";
        string archiveFolder = "archive";

        File.WriteAllText(logfile, "Log initiated: " + DateTime.Now + "\n");
        Console.WriteLine("Log File Created");

        File.AppendAllText(logfile, "User Has Logged In\n");
        File.AppendAllText(logfile, "User Uploaded File\n");

        Console.WriteLine("Data is Appended");

        string[] lines = File.ReadAllLines(logfile);

        foreach (var item in lines)
        {
            Console.WriteLine(item);
        }

        File.Copy(logfile, backupFile, overwrite: true);
        Console.WriteLine("Backup of log file Created");

        if (!Directory.Exists(archiveFolder))
        {
            Directory.CreateDirectory(archiveFolder);
            Console.WriteLine("Archive File Created");

        }
        if (File.Exists(backupFile))
        {
            File.Delete(backupFile);
            Console.WriteLine("Backup File Deleted");
        }
    }
}