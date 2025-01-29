using System;

namespace CalendarDisplayQuestion8
{
    public class CalendarDisplay
    {
        // Array to store month names
        private static readonly string[] monthNames = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };
        
        // Array to store days in each month
        private static readonly int[] daysInMonth = {
            31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
        };

        // Method to get month name
        public static string GetMonthName(int month)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month");
                
            return monthNames[month - 1];
        }

        // Method to check if year is leap year
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Method to get days in month
        public static int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month");
                
            if (month == 2 && IsLeapYear(year))
                return 29;
                
            return daysInMonth[month - 1];
        }

        // Method to get first day of month
        public static int GetFirstDayOfMonth(int month, int year)
        {
            if (month < 1 || month > 12)
                throw new ArgumentException("Invalid month");

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0/4 - y0/100 + y0/400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (1 + x + (31 * m0) / 12) % 7;
            
            return d0;
        }

        // Method to display calendar
        public static void DisplayCalendar(int month, int year)
        {
            // Display header
            string monthName = GetMonthName(month);
            Console.WriteLine("\n   " + monthName + " " + year);
            Console.WriteLine(" Sun Mon Tue Wed Thu Fri Sat");
            
            // Get first day and number of days
            int startDay = GetFirstDayOfMonth(month, year);
            int days = GetDaysInMonth(month, year);
            
            // Print initial spaces
            for (int i = 0; i < startDay; i++)
            {
                Console.Write("    ");
            }
            
            // Print days
            for (int day = 1; day <= days; day++)
            {
                Console.Write("{0,4}", day);
                
                if ((startDay + day) % 7 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

    class Calendar
    {
        static void TestCalendarDisplay()
        {
            // Get month and year from user
            Console.Write("Enter month (1-12): ");
            string monthInput = Console.ReadLine();
            Console.Write("Enter year: ");
            string yearInput = Console.ReadLine();
            
            // Validate input
            int month, year;
            if (!int.TryParse(monthInput, out month) || !int.TryParse(yearInput, out year) ||
                month < 1 || month > 12)
            {
                Console.WriteLine("Invalid input. Please enter valid month (1-12) and year.");
                return;
            }

            // Display calendar
            CalendarDisplay.DisplayCalendar(month, year);
        }

        static void Main(string[] args)
        {
            TestCalendarDisplay();
        }
    }
}