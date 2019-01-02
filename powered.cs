using System;

class Powered
{
    static void Main()
    {
        Console.Write("Enter first integer: ");
        string numString1 = Console.ReadLine();
        int num1 = Convert.ToInt32(numString1);

        Console.Write("Enter second integer: ");
        string numString2 = Console.ReadLine();
        int num2 = Convert.ToInt32(numString2);

        int result = (int) Math.Pow(num1, num2);

        Console.WriteLine("{0} powered by {1} = {2}", num1, num2, result);

    }
}