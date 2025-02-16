using System;
using System.IO;
using System.Text;

class ByteReader
{
	public static void Main(string[] args)
	{
		string filePath = "ByteReader.dat";

		// Check if the file exists
		if (!File.Exists(filePath))
		{
			Console.WriteLine("File not found: " + filePath);
			return;
		}

		// Read and print the file as characters
		ReadBinaryAsCharacters(filePath);
	}

	// Method to read a binary file as a character stream
	static void ReadBinaryAsCharacters(string filePath)
	{
		try
		{
			// Open the binary file using FileStream
			using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
			{
				int i;
				while((i = fs.ReadByte()) != -1)
				{
					Console.Write((char)i);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
	}
}
