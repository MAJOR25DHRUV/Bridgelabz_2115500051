Using System;
class CarRental
{
    private string customerName;
    private string carModel;
    private int rentalDays;

    public CarRental(string customerName, string carModel, int rentalDays)
    {
        this.customerName = customerName;
        this.carModel = carModel;
        this.rentalDays = rentalDays;
    }

    public double CalculateRentalCost()
    {
        return rentalDays * 50; // Assume 50 per day
    }
}