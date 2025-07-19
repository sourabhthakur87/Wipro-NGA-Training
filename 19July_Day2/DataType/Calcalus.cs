class Calcalus
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }
    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Division: " + (a / b));
        }
        else
        {
            Console.WriteLine("Cannot divide by zero");
        }
    }
}