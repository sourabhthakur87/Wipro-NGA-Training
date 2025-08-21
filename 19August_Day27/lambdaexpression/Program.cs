class Expressions
{
    public static void Main()
    {
        int[] numArr = [1, 4, 2, 5, 6, 2, 9, 5];
        string[] nameArr = ["John", "Wick", "Sourabh", "Ant", "Man", "Iron"];

        // even number using where 
        var evennumber = numArr.Where(n => n % 2 == 0);
        // foreach (var item in evennumber)
        // {
        //     Console.Write(item + ",");

        // }
        // Console.WriteLine();


        var squarednumber = numArr.Select(n => n * n);

        // foreach (var item in squarednumber)
        // {
        //     Console.WriteLine(item);
        // }


        var character = nameArr.SelectMany(w => w.ToCharArray());

        // foreach (var item in character)
        // {
        //     Console.Write(item + ",");

        // }


        var sorting = numArr.OrderBy(n => n);

        // foreach (var item in sorting)
        // {
        //     Console.Write(item + ",");
        // }


        var people = new[]
        {
            new { Name = "John", Age = 30 },
            new { Name = "Alice", Age = 25 },
            new { Name = "John", Age = 22 }
        };

        var sortedpeople = people.OrderBy(p => p.Name).ThenBy(p => p.Age);


        // foreach (var item in sortedpeople)
        // {
        //     Console.WriteLine(item.Name + " " + item.Age);
        // }


        // Console.WriteLine("Length of array "+numArr.Count());
        // Console.WriteLine("Sum of array "+numArr.Sum());


        var distinctNumber = numArr.Distinct();

        // foreach (var item in distinctNumber)
        // {
        //     Console.WriteLine(item);
        // }


        var firstTwo = numArr.Take(2);

        // foreach (var item in firstTwo)
        // {
        //     Console.WriteLine(item);
        // }


        
    }
}