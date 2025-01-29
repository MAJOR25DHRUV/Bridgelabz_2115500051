using System;

namespace CollinearPointsQuestion10
{
    public class PointChecker
    {
        // Method to check if points are collinear using slope method
        public static bool AreCollinearBySlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate slopes between pairs of points
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            double slope3 = (y3 - y1) / (x3 - x1);
            
            // Compare slopes (using small tolerance for floating point comparison)
            const double tolerance = 0.0001;
            return Math.Abs(slope1 - slope2) < tolerance && 
                   Math.Abs(slope2 - slope3) < tolerance;
        }

        // Method to check if points are collinear using area method
        public static bool AreCollinearByArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            // Calculate area of triangle formed by three points
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            
            // Points are collinear if area is zero
            return Math.Abs(area) < 0.0001;  // Using small tolerance for floating point comparison
        }

        // Method to format point for display
        public static string FormatPoint(double x, double y)
        {
            return string.Format("({0}, {1})", x, y);
        }
    }

    class CollinearPoints
    {
        static void TestPointChecker()
        {
            try
            {
                // Get input from user for three points
                Console.WriteLine("Enter coordinates for three points:");
                
                Console.Write("Enter x1: ");
                double x1 = double.Parse(Console.ReadLine());
                Console.Write("Enter y1: ");
                double y1 = double.Parse(Console.ReadLine());
                
                Console.Write("Enter x2: ");
                double x2 = double.Parse(Console.ReadLine());
                Console.Write("Enter y2: ");
                double y2 = double.Parse(Console.ReadLine());
                
                Console.Write("Enter x3: ");
                double x3 = double.Parse(Console.ReadLine());
                Console.Write("Enter y3: ");
                double y3 = double.Parse(Console.ReadLine());

                // Display points
                Console.WriteLine("\nPoints entered:");
                Console.WriteLine("Point 1: " + PointChecker.FormatPoint(x1, y1));
                Console.WriteLine("Point 2: " + PointChecker.FormatPoint(x2, y2));
                Console.WriteLine("Point 3: " + PointChecker.FormatPoint(x3, y3));

                // Check collinearity using both methods
                bool collinearBySlope = PointChecker.AreCollinearBySlope(x1, y1, x2, y2, x3, y3);
                bool collinearByArea = PointChecker.AreCollinearByArea(x1, y1, x2, y2, x3, y3);

                // Display results
                Console.WriteLine("\nCollinearity Check Results:");
                Console.WriteLine("Using Slope Method: " + (collinearBySlope ? "Points are collinear" : "Points are not collinear"));
                Console.WriteLine("Using Area Method: " + (collinearByArea ? "Points are collinear" : "Points are not collinear"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numeric values for coordinates.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            TestPointChecker();
        }
    }
}