using System;

// Base class representing a general Vehicle
class Vehicle
{
    public int MaxSpeed { get; set; }  // Stores the maximum speed of the vehicle
    public string FuelType { get; set; }  // Stores the type of fuel used by the vehicle

    // Virtual method to display vehicle information (to be overridden in subclasses)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle | Max Speed: {MaxSpeed} km/h, Fuel Type: {FuelType}");
    }
}

// Car class inherits from Vehicle
class Car : Vehicle
{
    public int SeatCapacity { get; set; }  // Stores the number of seats in the car

    // Overriding method to display details specific to Car
    public override void DisplayInfo()
    {
        Console.WriteLine($"Car | Max Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Seats: {SeatCapacity}");
    }
}

// Truck class inherits from Vehicle
class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }  // Stores the payload capacity of the truck in kg

    // Overriding method to display details specific to Truck
    public override void DisplayInfo()
    {
        Console.WriteLine($"Truck | Max Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Payload: {PayloadCapacity} kg");
    }
}

// Motorcycle class inherits from Vehicle
class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }  // Stores whether the motorcycle has a sidecar

    // Overriding method to display details specific to Motorcycle
    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle | Max Speed: {MaxSpeed} km/h, Fuel: {FuelType}, Sidecar: {HasSidecar}");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of different vehicle types
        Vehicle[] vehicles = {
            new Car { MaxSpeed = 220, FuelType = "Petrol", SeatCapacity = 5 },
            new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 5000 },
            new Motorcycle { MaxSpeed = 180, FuelType = "Petrol", HasSidecar = false }
        };

        // Loop through each vehicle and display its details
        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
