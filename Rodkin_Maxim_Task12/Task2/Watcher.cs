using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Task2
{
    class Watcher
    {
        public delegate bool Compare();
        private static string sourceDirectory;
        private static string targetDirectory;
        public static void Run(string source, string target, Compare comp)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(source);
            sourceDirectory = source;
            targetDirectory = target;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            // Only watch text files.
            watcher.Filter = "*.txt";

            // Add event handlers.
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnChanged);
            watcher.IncludeSubdirectories = true;

            // Begin watching.
            watcher.EnableRaisingEvents = true;
            // Wait for the user to quit the program.
           
            AddLog();
            while (comp()) ;
        }

        private static void AddLog()
        {
            if (Directory.Exists(targetDirectory) == false)
            {
                Directory.CreateDirectory(targetDirectory);
            }
            var newTarget = Path.Combine(targetDirectory, DateTime.Now.ToString("dd-MM-yyyy_HH.mm.ss"));
            CopyAll(sourceDirectory, newTarget);
        }

        private static void CopyAll(string source, string target)
        {

            DirectoryInfo sourceDirectory = new DirectoryInfo(source);
            DirectoryInfo targetDirectory = new DirectoryInfo(target);
            if (Directory.Exists(target) == false)
            {
                Directory.CreateDirectory(target);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo fi in sourceDirectory.GetFiles())
            {
              //  Console.WriteLine(@"Copying {0}\{1}", targetDirectory.FullName, fi.Name);
                fi.CopyTo(Path.Combine(target.ToString(), fi.Name), true);
            }

            // Copy each subdirectory using recursion.
            foreach (DirectoryInfo diSourceSubDir in sourceDirectory.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = targetDirectory.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir.FullName, nextTargetSubDir.FullName);
            }
        }

        public static void Rollback(string source, string target, string date)
        {
            var targetDirectory = new DirectoryInfo(target);
            var sourceDirectory = new DirectoryInfo(source);
            List<DateTime> directories = new List<DateTime>();
            foreach (var item in targetDirectory.GetDirectories())
            {
                directories.Add(DateTime.ParseExact(item.Name, "dd-MM-yyyy_HH.mm.ss", CultureInfo.InvariantCulture));
            }
            directories.Sort();
            //foreach (var item in directories)
            //{
            //    Console.WriteLine(item);
            //}
          //  Console.WriteLine("Enter date and time");
            var userDate = DateTime.Parse(date);
            for (int i = directories.Count - 1; i >= 0; i--)
            {
                if (userDate >= directories[i])
                {
                    sourceDirectory.Delete(true);
                    CopyAll(Path.Combine(target, directories[i].ToString("dd-MM-yyyy_HH.mm.ss")), source);
                    break;
                }
            }
        }

        // Define the event handlers.
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed, created, or deleted.
            AddLog();
          //  Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }
    }
}
