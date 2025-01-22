using System;

class Dist{
     public static void Main(string[] args){
        double km = 10.8;
        Console.WriteLine("Distance in miles is : "+Distc(km));

     }
     static double  Distc(double km){
        return km/1.6;

     }
}