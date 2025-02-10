using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("V001", "John Doe", 2.5),
            new Bike("V002", "Jane Smith", 1.5),
            new Auto("V003", "Bob Wilson", 2.0)
        };

        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine("Vehicle Details:");
            vehicle.GetVehicleDetails();
            Console.WriteLine("Fare for 10km: $" + vehicle.CalculateFare(10));
            
            // Using 'as' operator for interface checking
            IGPS gps = vehicle as IGPS;
            if (gps != null)
            {
                Console.WriteLine("Location: " + gps.GetCurrentLocation());
            }
            Console.WriteLine();
        }
    }
}

// Abstract base class for all vehicles
public abstract class Vehicle
{
    // Private fields for encapsulation
    private string vehicleId;
    private string driverName;
    private double ratePerKm;
    private string currentLocation;

    // Constructor to initialize vehicle details
    protected Vehicle(string vehicleId, string driverName, double ratePerKm)
    {
        this.VehicleId = vehicleId;
        this.DriverName = driverName;
        this.RatePerKm = ratePerKm;
        this.currentLocation = "Base Station";
    }

    // Public properties with validation
    public string VehicleId
    {
        get { return vehicleId; }
        private set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Vehicle ID cannot be empty");
            vehicleId = value;
        }
    }

    public string DriverName
    {
        get { return driverName; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Driver name cannot be empty");
            driverName = value;
        }
    }

    public double RatePerKm
    {
        get { return ratePerKm; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Rate cannot be negative");
            ratePerKm = value;
        }
    }

    // Protected method to update location
    protected void SetLocation(string location)
    {
        if (!string.IsNullOrEmpty(location))
        {
            currentLocation = location;
        }
    }

    // Protected method to get location
    protected string GetLocation()
    {
        return currentLocation;
    }

    // Abstract method for fare calculation
    public abstract double CalculateFare(double distance);

    // Concrete method for displaying vehicle details
    public virtual void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle ID: " + VehicleId);
        Console.WriteLine("Driver: " + DriverName);
        Console.WriteLine("Rate per km: $" + RatePerKm);
    }
}

// Interface for GPS functionality
public interface IGPS
{
    string GetCurrentLocation();
    void UpdateLocation(string location);
}

// Car implementation
public class Car : Vehicle, IGPS
{
    // Constructor
    public Car(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    // Implementation of abstract method
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 1.2; // 20% premium for car service
    }

    // Implementation of interface methods
    public string GetCurrentLocation()
    {
        return "Car - " + GetLocation();
    }

    public void UpdateLocation(string location)
    {
        SetLocation(location);
    }
}

// Bike implementation
public class Bike : Vehicle, IGPS
{
    // Constructor
    public Bike(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    // Implementation of abstract method
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm * 0.8; // 20% discount for bike service
    }

    // Implementation of interface methods
    public string GetCurrentLocation()
    {
        return "Bike - " + GetLocation();
    }

    public void UpdateLocation(string location)
    {
        SetLocation(location);
    }
}

// Auto implementation
public class Auto : Vehicle, IGPS
{
    // Constructor
    public Auto(string vehicleId, string driverName, double ratePerKm)
        : base(vehicleId, driverName, ratePerKm) { }

    // Implementation of abstract method
    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm; // Standard rate for auto
    }

    // Implementation of interface methods
    public string GetCurrentLocation()
    {
        return "Auto - " + GetLocation();
    }

    public void UpdateLocation(string location)
    {
        SetLocation(location);
    }
}