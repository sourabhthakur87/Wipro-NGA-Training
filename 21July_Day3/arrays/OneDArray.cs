class OneDArray
{
    public void SingleDArray()
    {
        Console.WriteLine("Enter the number of Studnts");
        int number = Convert.ToInt16(Console.ReadLine());

        string[] arr = new string[number];

        Console.WriteLine("Enter the name of Students:- ");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Console.ReadLine() ?? string.Empty;
        }

        Console.WriteLine("Students Names Are:- ");

        foreach (string name in arr)
        {
            Console.Write($"{name} ");
        }
    }
}