using System;

class Vehicle
{
    // Static variable shared by all vehicles to store the registration fee
    static double RegistrationFee = 100.0;
    
    // Instance variables for OwnerName, VehicleType
    public string OwnerName;
    public string VehicleType;
    
    // Readonly variable for RegistrationNumber to ensure it's unique and cannot be changed once assigned
    public readonly string RegistrationNumber;

    // Static method to update the registration fee for all vehicles
    public static void UpdateRegistrationFee(double newFee)
    {
        // Updating the static RegistrationFee variable with the new value
        RegistrationFee = newFee;
    }

    // Constructor to initialize OwnerName, VehicleType, and RegistrationNumber using 'this' keyword
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        // Initializing instance variables using constructor parameters
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
    }

    // Instance method to display vehicle registration details
    public void DisplayDetails()
    {
        // Checking if the current object is an instance of the Vehicle class using 'is' operator
        if (this is Vehicle)
        {
            // Printing vehicle registration details including RegistrationNumber, OwnerName, VehicleType, and RegistrationFee
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Owner Name: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Fee: $" + RegistrationFee);
        }
    }

    static void Main(string[] args)
    {
        // Creating two vehicle objects with unique registration numbers
        Vehicle vehicle1 = new Vehicle("John Doe", "Car", "ABC123");
        Vehicle vehicle2 = new Vehicle("Jane Smith", "Truck", "XYZ456");

        // Displaying vehicle details
        vehicle1.DisplayDetails();
        vehicle2.DisplayDetails();

        // Updating the registration fee for all vehicles using the static method
        Vehicle.UpdateRegistrationFee(150.0);

        // Displaying updated vehicle details after changing the registration fee
        Console.WriteLine("\nAfter Registration Fee Update:");
        vehicle1.DisplayDetails();
        vehicle2.DisplayDetails();
    }
}
