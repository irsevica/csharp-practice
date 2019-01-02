using System;

class CharClass
{
    static void Main()
    {
        char myChar = (char)65;
        int yourChar = 'A';

        Console.WriteLine("The character is: {0}", myChar);
        Console.WriteLine("The code of the character is: {0}", yourChar);

        Console.WriteLine("{0:C}", 1.2);
        Console.WriteLine("{0:D5}", 123);
    }
}