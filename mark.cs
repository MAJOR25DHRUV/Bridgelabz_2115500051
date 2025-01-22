using System;
class mark
{
    static void Main(string[] args)
    {
        int chem=96;
        int math=94;
        int phy=95;

        Console.WriteLine("Average number" + average(chem,math,phy));
    }
    static double average(int chem,int math,int phy )
    {
        return ((chem+math+phy)/3.0);

    
    }
}