using System;

class DateFormatter
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine("Date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("Date in EEE, MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}



