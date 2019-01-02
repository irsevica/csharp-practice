using System;

class ArithmeticTest
{
    static void Main()
    {
        int x = 10;
        int y = 100;
        int z = y;

        y = y++ + x;
        z = ++z + x;

        Console.WriteLine(y);
        Console.WriteLine(x);

        Console.WriteLine(123.GetType());
        Console.WriteLine(3.14.GetType());

        decimal myDecimal =  23.4M;
        float myFloat = 23.4F;
        double myDouble = 23.4;

        Console.WriteLine(myDecimal.GetType());
        Console.WriteLine(myFloat.GetType());
        Console.WriteLine(myDouble.GetType());

    }
}