using System;

class Employee
{

    public string Name { get; set; }
    public int Age { get; set; }

    public static int Count = 0;

    public Employee()
    {
        Name = "niti";
        Age = 34;
    }
    public Employee(string name, int age)
    {

        Name = name;
        Age = age;

    }


    // static constructor will run only once , not as  per the object 
    // static Employee()
    // {

    //     Count++;
    //     Console.WriteLine("The value of count is : " + Count);
    // }


    public void Display()
    {
        Count++;
        Console.WriteLine("The value of count is : " + Count);

        Console.WriteLine("Name : " + Name + "   Age : " + Age);
    }

}

