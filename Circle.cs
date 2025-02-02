using System;
class Circle
{
    private double radius;

    public Circle() : this(1.0) { } // Default Constructor

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}