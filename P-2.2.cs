using System;
using System.IO;

namespace Practice_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex. 1 
            StreamWriter writer = File.CreateText(@"F:\newfile.txt");
            writer.WriteLine("This is my new file");
            writer.WriteLine("Do you like its format?");
            writer.Close();
            //ex. 2
            StreamReader reader = File.OpenText(@"F:\newfile.txt");
            string contents = reader.ReadToEnd();
            reader.Close();
            Console.WriteLine(contents);
        }
    }
}
