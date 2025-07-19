using System;
class mainProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the main program");

        // Calcalus cal = new Calcalus();
        // Console.WriteLine("Performing calculations:");
        // Console.WriteLine("Addition: " + cal.Add(10, 5));
        // cal.Subtract(10, 5);
        // cal.Multiply(10, 5);
        // cal.Divide(10, 0);

        // Console.WriteLine(cal.GetType());

        ControlFlow controlFlow = new ControlFlow();
        Console.WriteLine("Checking number:");
        controlFlow.CheckNumber(10);
        controlFlow.CheckNumber(-5);
        controlFlow.CheckNumber(0);
    }
}
