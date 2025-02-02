class Vehicle
{
    public string OwnerName { get; set; }
    public string VehicleType { get; set; }
    private static double registrationFee = 5000; // Class variable

    public Vehicle(string ownerName, string vehicleType)
    {
        OwnerName = ownerName;
        VehicleType = vehicleType;
    }

    public void DisplayVehicleDetails()
    {
        Console.WriteLine($"Owner: {OwnerName}, Vehicle Type: {VehicleType}, Registration Fee: {registrationFee}");
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        registrationFee = newFee;
    }
}

class Program
{
    static void Main()
    {
        Vehicle car = new Vehicle("Alice", "Sedan");
        car.DisplayVehicleDetails();

        Vehicle.UpdateRegistrationFee(5500);
        Vehicle bike = new Vehicle("Bob", "Motorcycle");
        bike.DisplayVehicleDetails();
    }
}
