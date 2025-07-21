using System;

namespace StudentProgram;  // Package

class Student
{

    static int count = 0;

    Student()
    {
        count++;
        Console.WriteLine("The Static Count is " + count);
    }


    public string Name { get; set; }
    public int Age { get; set; }
    public int[] SubjectMarks { get; set; }


}