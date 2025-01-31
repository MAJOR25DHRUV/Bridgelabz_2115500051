using System;

class Circle {
    private int radius;

    // Constructor
    public Circle(int radius) {
        this.radius = radius;
    }

    // Getter method for radius (since auto-properties are not supported in older C#)
    public int GetRadius() {
        return radius;
    }

    public double Area() {
        return Math.PI * radius * radius;  // More precise
    }

    public double Circumference() {
        return 2 * Math.PI * radius;
    }
}

class Program {
    public static void Main(string[] args) {
        Console.Write("Enter the radius of the Circle: ");
        int radius = Convert.ToInt32(Console.ReadLine());

        Circle obj = new Circle(radius);

        Console.WriteLine(string.Format("Area: {0}", obj.Area()));
        Console.WriteLine(string.Format("Circumference: {0}", obj.Circumference()));
    }
}
