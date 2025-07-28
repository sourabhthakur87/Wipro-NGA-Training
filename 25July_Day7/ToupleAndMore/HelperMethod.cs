// class HelperMethod
// {
//     public static void Main()
//     {
//         int n = 12;

//         int result = Factorial(n);
//         Console.WriteLine("The Factorial is: " + result);
//     }

//     static int Factorial(int n)
//     {
//         static int factor()
//         {
//             int result = 1;
//             for (int i = 2; i <= n; i++)
//             {
//                 result *= i;
//             }
//             result result;
//         }
//         return factor();
//     }
// }




// Reference Example

// class ReferenceExample
// {
//     static ref int Find(int[] arr, int val)
//     {
//         //  return a reference to an element in the array
//         return ref arr[Array.IndexOf(arr, val)];
//     }

//     static void Main()
//     {
//         int[] data = [2, 4, 3, 1];
//         ref int x = ref Find(data, 1);

//         x = 23;
//         Console.WriteLine(string.Join(",",data));

//     }


// }




// Indexers

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    Employee(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }

    public Object this[int index]
    {
        get
        {
            if (index == 0)
            {
                return Id;
            }
            else if (index == 1)
            {
                return Name;
            }
            else
            {
                return null;
            }
        }
        set
        {
            if (index == 0)
            {
                Id = Convert.ToInt32(value);
            }
            else if (index == 2)
            {
                Name = value.ToString();
            }
        }
    }

    public static void Main()
    {
        Employee e = new Employee(101, "Sourabh");
        Console.WriteLine(e[1]);

        // Example of Out Parameter
        if (int.TryParse("1a", out int value))
        {
            Console.WriteLine("The Value is converting to int");
        }
        else
        {
            Console.WriteLine("Value does not Converted");
        }
    }

}