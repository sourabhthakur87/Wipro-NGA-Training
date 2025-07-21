class SwitchCase
{
    public void CheckDay(int day)
    {
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                Addnumbers(5, 10);
                break;
            default:
                Console.WriteLine("Invalid day");
                break;

        }
    }
    public void Addnumbers(int a, int b)
    {
        Console.WriteLine($"The sum of {a} and {b} is {a + b}");
    }
}
