class Looping
{
    public void NumberTable()
    {
        // Using While Loop
        int a = 2;
        // while (a <= 20)
        // {
        //     Console.Write($"{a} ,");
        //     a += 2;
        // }

        // Using For Loop

        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine($"2 x {i} = {i * 2}");
        // }

        // Using Do-While Loop
        // do
        // {
        //     Console.Write($"{a} ,");
        //     a += 2;
        // } while (a <= 20);


        // Using ForEach Loop
        string[] names = ["Ram", "Shyam", "Sita", "Gita"];
        foreach (string name in names)
        {
            Console.Write($"{name} ");
        }
        Console.WriteLine();
        Console.WriteLine(names[2]);
    }
}
