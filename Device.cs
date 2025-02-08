using System;

// Base class representing a generic Device
class Device
{
    public int DeviceId { get; set; }  // Unique ID for the device
    public string Status { get; set; }  // Stores the status of the device (ON/OFF)

    // Method to display device status
    public virtual void DisplayStatus()
    {
        Console.WriteLine($"Device ID: {DeviceId}, Status: {Status}");
    }
}

// Thermostat class inherits from Device
class Thermostat : Device
{
    public int TemperatureSetting { get; set; }  // Stores the temperature setting

    // Overriding DisplayStatus() to include thermostat-specific details
    public override void DisplayStatus()
    {
        Console.WriteLine($"Thermostat ID: {DeviceId}, Status: {Status}, Temperature: {TemperatureSetting}°C");
    }
}

// Main program to test the classes
class Program
{
    static void Main()
    {
        // Creating an instance of Thermostat
        Thermostat thermostat = new Thermostat
        {
            DeviceId = 101,
            Status = "ON",
            TemperatureSetting = 24
        };

        // Displaying thermostat details
        thermostat.DisplayStatus();
    }
}
