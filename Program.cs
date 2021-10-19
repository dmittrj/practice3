using System;
using System.IO;
using System.IO.Compression;

namespace Practice_2._3
{
    class Program
    {
        static void CompressFile(string inFileName, string outFileName)
        {
            FileStream sourceFile = File.OpenRead(inFileName);
            FileStream destFile = File.Create(outFileName);
            GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
        }

        static void UncompressFile(string inFileName, string outFileName)
        {
            FileStream sourceFile = File.OpenRead(inFileName);
            FileStream destFile = File.Create(outFileName);
            GZipStream compStream = new GZipStream(sourceFile, CompressionMode.Decompress);
            int theByte = sourceFile.ReadByte();
            while (theByte != -1)
            {
                compStream.WriteByte((byte)theByte);
                theByte = sourceFile.ReadByte();
            }
            compStream.Close();
        }
        static void Main(string[] args)
        {
            CompressFile(@"f:\\1.txt", @"f:\\1.txt.gz");
            CompressFile(@"f:\\1.txt.gz", @"f:\\1gz.txt");
        }
    }
}
