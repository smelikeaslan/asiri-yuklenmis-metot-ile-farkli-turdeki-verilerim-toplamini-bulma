using System;

class Program
{
    static void Main(string[] args)
    {
        
        int sum1 = CalculateSum(5, 10);
        Console.WriteLine("İki int sayının toplamı: " + sum1);

        
        double sum2 = CalculateSum(5.5, 10.5);
        Console.WriteLine("İki double sayının toplamı: " + sum2);

        
        int sum3 = CalculateSum(3, 7, 12);
        Console.WriteLine("Üç int sayının toplamı: " + sum3);
    }

    
    static int CalculateSum(int a, int b)
    {
        return a + b;
    }

    
    static double CalculateSum(double a, double b)
    {
        return a + b;
    }

    
    static int CalculateSum(int a, int b, int c)
    {
        return a + b + c;
        Console.ReadKey();
    }
}