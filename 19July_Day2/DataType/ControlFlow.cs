class ControlFlow
{
    public void CheckNumber(int number)
    {
        if (number > 0)
        {
            Console.WriteLine(number + " is a positive number.");
        }
        else if (number < 0)
        {
            Console.WriteLine(number + " is a negative number.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}
