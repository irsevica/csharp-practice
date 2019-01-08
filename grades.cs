using System;

class Grades
{
    static void Main()
    {
        string[,] gradesArray = new string[2, 4] { {"Pass", "Good", "VeryGood", "Distinct"}, {"55%", "65%", "75%", "85%"} };

        for (int x =0; x < 4; x++)
        {
            Console.Write("Grade={0}\t", gradesArray[0,x]);
            Console.WriteLine("Score={0}",gradesArray[1, x]);
        }
    }
}