using System;

public class Citizen
{
    string ssn = "555-55-5555";
    string age = "36";

    public void GetPersonalInfo()
    {
        Console.WriteLine("SSN: {0}", ssn);
        Console.WriteLine("Age: {0}", age);
    }
}

public partial class Employee: Citizen
{
    public void DisplayInfo()
    {
        Console.WriteLine("Citizen's Information: ");
        GetPersonalInfo();
        Console.WriteLine("\nJob Information:");
        Console.WriteLine("Company name: {0}", name);
        Console.WriteLine("Company ID: {0}", id);
    }
}

class MyClass
{
    static void Main(string[] args)
    {
        //Create object
        Employee emp = new Employee();

        //Read name and id:
        Console.Write("Please enter the employee's name: ");
        emp.Name =  Console.ReadLine();
        Console.Write("Please enter the employee's ID: ");
        emp.Id = Console.ReadLine();

        // Display information
        emp.DisplayInfo();
    }

}
