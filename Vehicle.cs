using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C001", "Sedan", 50.0),
            new Bike("B001", "Sports", 20.0),
            new Truck("T001", "Cargo", 100.0)
        };

        // Loop through each vehicle
        foreach (Vehicle vehicle in vehicles)
        {
            Console.WriteLine("Vehicle Details:");
            Console.WriteLine("Number: " + vehicle.VehicleNumber);
            Console.WriteLine("Type: " + vehicle.Type);
            Console.WriteLine("Rental Cost (5 days): $" + vehicle.CalculateRentalCost(5));

            // Explicitly checking if the vehicle implements IInsurable
            IInsurable insurable = vehicle as IInsurable;
            if (insurable != null)
            {
                Console.WriteLine("Insurance Cost: $" + insurable.CalculateInsurance());
                Console.WriteLine("Insurance Details: " + insurable.GetInsuranceDetails());
            }

            Console.WriteLine();
        }
    }
}

// Abstract base class for all vehicles
public abstract class Vehicle
{
    // Private fields for encapsulation
    private string vehicleNumber;
    private string type;
    private double rentalRate;

    // Constructor to initialize vehicle details
    protected Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        this.VehicleNumber = vehicleNumber;
        this.Type = type;
        this.RentalRate = rentalRate;
    }

    // Public properties with validation
    public string VehicleNumber
    {
        get { return vehicleNumber; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Vehicle number cannot be empty");
            vehicleNumber = value;
        }
    }

    public string Type
    {
        get { return type; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Type cannot be empty");
            type = value;
        }
    }

    public double RentalRate
    {
        get { return rentalRate; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Rental rate cannot be negative");
            rentalRate = value;
        }
    }

    // Abstract method for rental cost calculation
    public abstract double CalculateRentalCost(int days);
}

// Interface for insurable vehicles
public interface IInsurable
{
    double CalculateInsurance();
    string GetInsuranceDetails();
}

// Car implementation
public class Car : Vehicle, IInsurable
{
    // Private field for insurance policy
    private string insurancePolicy;

    // Constructor
    public Car(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate)
    {
        insurancePolicy = "CAR-INS-" + vehicleNumber;
    }

    // Implementation of abstract method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days;
    }

    // Implementation of interface methods
    public double CalculateInsurance()
    {
        return RentalRate * 0.2; // 20% of rental rate
    }

    public string GetInsuranceDetails()
    {
        return "Policy Number: " + insurancePolicy + " - Full Coverage";
    }
}

// Bike implementation
public class Bike : Vehicle, IInsurable
{
    // Private field for insurance policy
    private string insurancePolicy;

    // Constructor
    public Bike(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate)
    {
        insurancePolicy = "BIKE-INS-" + vehicleNumber;
    }

    // Implementation of abstract method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 0.8; // 20% discount for bikes
    }

    // Implementation of interface methods
    public double CalculateInsurance()
    {
        return RentalRate * 0.15; // 15% of rental rate
    }

    public string GetInsuranceDetails()
    {
        return "Policy Number: " + insurancePolicy + " - Basic Coverage";
    }
}

// Truck implementation
public class Truck : Vehicle, IInsurable
{
    // Private field for insurance policy
    private string insurancePolicy;

    // Constructor
    public Truck(string vehicleNumber, string type, double rentalRate)
        : base(vehicleNumber, type, rentalRate)
    {
        insurancePolicy = "TRUCK-INS-" + vehicleNumber;
    }

    // Implementation of abstract method
    public override double CalculateRentalCost(int days)
    {
        return RentalRate * days * 1.2; // 20% surcharge for trucks
    }

    // Implementation of interface methods
    public double CalculateInsurance()
    {
        return RentalRate * 0.3; // 30% of rental rate
    }

    public string GetInsuranceDetails()
    {
        return "Policy Number: " + insurancePolicy + " - Commercial Coverage";
    }
}
