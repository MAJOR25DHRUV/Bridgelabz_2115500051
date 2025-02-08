using System;

// Base class representing a Vehicle
class Vehicleh
{
    public int MaxSpeed { get; set; }  // Stores the maximum speed of the vehicle
    public string Model { get; set; }  // Stores the vehicle model

    // Method to display vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}, Max Speed: {MaxSpeed} km/h");
    }
}

// Defining an interface Refuelable
interface Refuelable
{
    void Refuel();  // Abstract method to be implemented by PetrolVehicle
}

// ElectricVehicle class inherits from Vehicle
class ElectricVehicle : Vehicle
{
    public int BatteryCapacity { get; set; }  // Stores battery capacity

    // Method to charge the vehicle
    public void Charge()
    {
        Console.WriteLine($"Charging {Model} with {BatteryCapacity} kWh battery.");
    }
}

// PetrolVehicle class inherits from Vehicle and implements Refuelable interface
class PetrolVehicle : Vehicle, Refuelable
{
    public int FuelCapacity { get; set; }  // Stores fuel capacity

    // Implementing the interface method
    public void Refuel()
    {
        Console.WriteLine($"Refueling {Model} with {FuelCapacity} liters of petrol.");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating instances of ElectricVehicle and PetrolVehicle
        ElectricVehicle ev = new ElectricVehicle { Model = "Tesla Model 3", MaxSpeed = 200, BatteryCapacity = 75 };
        PetrolVehicle pv = new PetrolVehicle { Model = "Toyota Corolla", MaxSpeed = 180, FuelCapacity = 50 };

        // Displaying vehicle details and performing actions
        ev.DisplayInfo();
        ev.Charge();

        pv.DisplayInfo();
        pv.Refuel();
    }
}
