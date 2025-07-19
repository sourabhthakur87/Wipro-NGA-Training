class IfElse
{
    public void PrintNumbers()
    {
        Console.WriteLine("Enter Number:- ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine($"{n} is Even Number");
        }
        else
        {
            Console.WriteLine($"{n} is Odd Number");
        }
    }
}