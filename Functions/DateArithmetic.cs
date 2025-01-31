using System;

class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate = DateTime.Parse(Console.ReadLine());

        DateTime newDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        newDate = newDate.AddDays(-21); // Subtracting 3 weeks (21 days)

        Console.WriteLine(string.Format("Updated Date: {0:yyyy-MM-dd}", newDate));
    }
}
