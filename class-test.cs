using System;

public class MyClass
{
    private MyClass() {} //private constructor
    public string companyName;
    public string employmentDate;
}

class MainClass
{
    static void Main()
    {
        MyClass mc = new MyClass(); // error CS0122: 'MyClass.MyClass()' is inaccessible due to its protection level
    }
}

