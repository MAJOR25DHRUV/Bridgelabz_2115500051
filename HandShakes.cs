using  System;

class HandShake{
    public static void Main(string[] args){
        int n = Convert.ToInt32(Console.ReadLine()); // Number of people in the room
        int totalHandshakes = CalculateHandshakes(n); // Calculate total handshakes
        Console.WriteLine("Total number of handshakes: " + totalHandshakes);
    }
    static int CalculateHandshakes(int n){
        if(n == 0 || n == 1) return 0; // Base case: 0 or 1 people can't form handshakes
        else return n * (n - 1) / 2; // Recursive formula to calculate total handshakes

    }
}