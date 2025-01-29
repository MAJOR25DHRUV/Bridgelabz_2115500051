using System;

namespace EuclideanDistanceQuestion9
{
    public class PointCalculator
    {
        // Method to calculate Euclidean distance
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            
            return Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
        }

        // Method to find line equation
        public static double[] GetLineEquation(double x1, double y1, double x2, double y2)
        {
            // Calculate slope
            double slope = (y2 - y1) / (x2 - x1);
            
            // Calculate y-intercept (b)
            double yIntercept = y1 - slope * x1;
            
            // Return array containing slope and y-intercept
            return new double[] { slope, yIntercept };
        }

        // Method to format line equation as string
        public static string FormatLineEquation(double[] equation)
        {
            double slope = equation[0];
            double yIntercept = equation[1];
            
            string equation1 = "y = ";
            equation1 += slope.ToString("F2") + "x";
            equation1 += (yIntercept >= 0) ? " + " : " - ";
            equation1 += Math.Abs(yIntercept).ToString("F2");
            
            return equation1;
        }
    }

    class Euclidean
    {
        static void TestPointCalculator()
        {
            // Get input from user
            Console.WriteLine("Enter coordinates for two points:");
            
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            // Calculate distance
            double distance = PointCalculator.CalculateDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean distance: " + distance.ToString("F2"));
            
            // Calculate and display line equation
            double[] equation = PointCalculator.GetLineEquation(x1, y1, x2, y2);
            string lineEquation = PointCalculator.FormatLineEquation(equation);
            Console.WriteLine("Line equation: " + lineEquation);
        }

        static void Main(string[] args)
        {
            TestPointCalculator();
        }
    }
}