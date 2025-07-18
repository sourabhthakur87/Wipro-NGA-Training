internal class Calculator
{
    // Creating method for addition
    public static void Main(string[] args)
    {
        int num1;
        int num2;
        Console.WriteLine("Enter num1:- ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2:- ");
        num2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"The subtraction of two number is:-  {num1 - num2}");
        Console.WriteLine($"The sum of two number is:-  {num1 + num2}");
        Console.ReadKey();
        const double PI = 3.14;
       
    }
}