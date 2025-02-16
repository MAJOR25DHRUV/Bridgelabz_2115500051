using System;
using System.IO;

class InputReader
{
    public static void Main(string[] args)
    {
        string filePath = "InputReader.txt";

        Console.WriteLine("Enter the text below to add in the file: ");
        string text = Console.ReadLine();

        // Write user input to the file and read it back
        Console.WriteLine(ReadUserInputAndAddToFile(filePath, text));
    }

    static string ReadUserInputAndAddToFile(string filePath, string text)
    {
        try
        {
            // Write text to the file (overwrite if exists)
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(text);
            }

            // Read the text back from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                return "File Content: " + reader.ReadToEnd();
            }
        }
        catch (IOException e)
        {
            return "Error: " + e.Message;
        }
    }
}
