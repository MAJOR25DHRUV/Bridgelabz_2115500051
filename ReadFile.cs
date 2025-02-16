using System;
using System.IO;

class ReadFile
{
    static void Main(string[] args)
    {
        // Define the file path for reading
        string filePath = "ReadFile.txt";
        
        try
        {
            // Open the file using StreamReader within a using statement
            using (StreamReader sr = new StreamReader(filePath))
            {
                // Declare a string variable to store each line
                string line;
                
                // Read the file line by line until the end is reached
                while ((line = sr.ReadLine()) != null)
                {
                    // Print the current line to the console
                    Console.WriteLine(line);
                }
            }
        }
        // Catch any IO exceptions that might occur
        catch (IOException e)
        {
            // Print the exception message to the console
            Console.WriteLine(e.Message);
        }
    }
}
