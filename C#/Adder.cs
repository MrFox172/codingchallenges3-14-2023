using System;

public class Adder
{
    public static void Main(string[] args)
    {
        Console.WriteLine (Sum(3,2));
        Console.WriteLine (Sum(-3,-6));
        Console.WriteLine (Sum(7,3));
    }
    public static int Sum(int a, int b)
    {
        return a+b;
    }
}