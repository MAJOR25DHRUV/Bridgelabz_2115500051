using System;

public class CircularTour
{
    // Class to represent each petrol pump
    public class PetrolPump
    {
        public int Petrol; // Amount of petrol available at the pump
        public int Distance; // Distance to the next pump

        // Constructor to initialize a petrol pump
        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            Distance = distance;
        }
    }

    // Method to find the starting petrol pump for a circular tour
    public static int FindStartingPoint(PetrolPump[] pumps)
    {
        // Stores the starting index of the tour
        int start = 0;

        // Tracks the current petrol balance
        int currentPetrol = 0;

        // Tracks the total petrol balance
        int totalPetrol = 0;

        // Traverse all petrol pumps
        for (int i = 0; i < pumps.Length; i++)
        {
            // Update total petrol balance considering this pump
            totalPetrol += pumps[i].Petrol - pumps[i].Distance;

            // Update current petrol balance
            currentPetrol += pumps[i].Petrol - pumps[i].Distance;

            // If current petrol becomes negative, restart from the next pump
            if (currentPetrol < 0)
            {
                // Update the starting pump index
                start = i + 1;

                // Reset current petrol balance
                currentPetrol = 0;
            }
        }

        // If total petrol is non-negative, a tour is possible, otherwise return -1
        return totalPetrol >= 0 ? start : -1;
    }

    public static void Main(string[] args)
    {
        // Create an array of petrol pumps
        PetrolPump[] pumps = new PetrolPump[]
        {
            new PetrolPump(6, 4),
            new PetrolPump(3, 6),
            new PetrolPump(7, 3),
            new PetrolPump(4, 5)
        };

        // Print details of each petrol pump
        Console.WriteLine("Petrol Pumps:");
        for (int i = 0; i < pumps.Length; i++)
        {
            Console.WriteLine("Pump " + i + ": Petrol = " + pumps[i].Petrol + 
                            ", Distance = " + pumps[i].Distance);
        }

        // Find the starting point for a circular tour
        int startPoint = FindStartingPoint(pumps);

        // Print the result
        if (startPoint >= 0)
        {
            Console.WriteLine("\nA circular tour is possible starting from pump " + startPoint);
        }
        else
        {
            Console.WriteLine("\nNo circular tour is possible");
        }
    }
}
