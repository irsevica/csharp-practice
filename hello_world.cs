using System;

/// <summary>
/// A test project to show documentation comments.
/// </summary>

class HelloWorld
{
    /// <summary>
    /// The Main method of the program.
    /// </summary>
    /// <param name="args">Command-line arguments.</param>
    /// <returns>Does not return a value.</returns>
    static void Main(String[] args)
    {
        string myString = "Hello, World!";
        int myInt = 9;
        Console.WriteLine("The string is: " + myString);
        Console.WriteLine("My integer: " + myInt.ToString());
        Console.WriteLine("My integer embedded conversion: " + myInt);
        Console.WriteLine("My interger: {0}", myInt);
        Console.WriteLine("Hello, C# user!");
    }
}