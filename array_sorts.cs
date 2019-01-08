using System;

class MyClass
{
    static void Main()
    {
        int[] myArray = { 1, 4, 25, 3};

        //Display the array

        foreach (int i in myArray)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("Original");

        //Sort, then display

        Array.Sort(myArray);
        foreach (int i in myArray)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("Sorted");


        Array.Reverse(myArray);
        foreach (int i in myArray)
        {
            Console.Write("{0} ", i);
        }
        Console.WriteLine("Reversed");

    }
}