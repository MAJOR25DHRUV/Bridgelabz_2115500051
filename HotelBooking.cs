using System;
class HotelBooking
{
    private string guestName;
    private string roomType;
    private int nights;

    public HotelBooking()
    {
        guestName = "Unknown";
        roomType = "Standard";
        nights = 1;
    }

    public HotelBooking(string guestName, string roomType, int nights)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.nights = nights;
    }

    public HotelBooking(HotelBooking existingBooking)
    {
        this.guestName = existingBooking.guestName;
        this.roomType = existingBooking.roomType;
        this.nights = existingBooking.nights;
    }
}