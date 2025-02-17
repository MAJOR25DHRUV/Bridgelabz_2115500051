using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class LargeFileReadingComparison
{
    // Reads file using StreamReader character by character
    public static void ReadWithStreamReader(string filePath)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.Read() != -1) { }
        }
        
        sw.Stop();
        Console.WriteLine("StreamReader Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Reads file using FileStream and processes bytes directly
    public static void ReadWithFileStream(string filePath)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[4096];
            while (fs.Read(buffer, 0, buffer.Length) > 0) { }
        }
        
        sw.Stop();
        Console.WriteLine("FileStream Time: " + sw.ElapsedMilliseconds + " ms");
    }

    static void Main(string[] args)
    {
        string filePath = "largefile.dat"; 
        Console.WriteLine("Testing large file reading efficiency...");
        ReadWithStreamReader(filePath);
        ReadWithFileStream(filePath);
    }
}
