// Create a collection of students to store student id ,student name and  subjectmarks(key as a subject and value as a marks)
// then display each student detail with average score

class Students
{
    public string name { get; set; }
    public int id { get; set; }

    public Dictionary<string, int> SubMarks = new Dictionary<string, int>();

    public double GetAverage(int total, int cout)
    {
        return total / cout;
    }



}
class MainProgram
{
    public static void Main()
    {
        List<Students> s1 = new List<Students>();
        // s1.Add(new Students
        // {
        //     id = 1,
        //     name = "Gita",

        //     SubMarks = new Dictionary<string, int>
        //     {
        //         {"Maths",12},
        //         {"Science",13},
        //         {"English",14}
        //     }
        // });
        // s1.Add(new Students
        // {
        //     id = 2,
        //     name = "Ram",

        //     SubMarks = new Dictionary<string, int>
        //     {
        //         {"Maths",10},
        //         {"Science",10},
        //         {"English",10}
        //     }
        // });

        Console.WriteLine("Enter the number of Students");
        int StudentCount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < StudentCount; i++)
        {
            Students student = new Students();

            Console.WriteLine("Enter Id of Student ");
            student.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of Student ");
            student.name = Console.ReadLine();

            Console.WriteLine("Enter Number of subjects ");

            int subjectCount = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < subjectCount; j++)
            {
                Console.WriteLine("Enter Subject Name:-");
                string subject = Console.ReadLine();
                Console.WriteLine($"Enter Marks for {subject} Name:-");
                int marks = Convert.ToInt32(Console.ReadLine());

                student.SubMarks[subject] = marks;
            }

            s1.Add(student);


        }

        foreach (var detail in s1)
        {
            Console.WriteLine($"The Id is {detail.id} and name is {detail.name}");
            Console.WriteLine("Subject Marks are");

            int totalMarks = 0;
            int cout = detail.SubMarks.Count;
            foreach (var sub in detail.SubMarks)
            {

                Console.WriteLine($"The Subject is {sub.Key} and the Marks is {sub.Value}");
                totalMarks += sub.Value;
            }
            Console.WriteLine($"The Average is {detail.GetAverage(totalMarks, cout)}");
            Console.WriteLine(new string('-', 40));
        }



    }
}