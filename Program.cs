using System;
using System.IO;

namespace Practice_2._1
{
    class Program
    {
        //ex. 1
        static void ShowDirectory(DirectoryInfo dir)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                try
                {
                    Console.WriteLine("File: {0}", file.FullName);
                } 
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                try
                {
                    ShowDirectory(subDir);
                }
                catch (Exception a)
                {
                    Console.WriteLine("\nATTENTION!\n{0}\n", a.Message);
                }
            }
        }
        //ex. 2
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
            
        }
        static void Main(string[] args)
        {
            //ex. 1
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);
            ShowDirectory(dir);
            //ex. 2
            
            FileSystemWatcher watcher = new FileSystemWatcher(Environment.SystemDirectory);
            watcher.Filter = "*.ini";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.EnableRaisingEvents = true;
        }
    }
}
