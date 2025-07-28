class MultiCastDeligate
{
    public delegate int NumbersDeligate(int a, int b);
    public delegate void PrintDeligate(int result);

    public static void Main()
    {
        NumbersDeligate add = Addition;
        NumbersDeligate difference = Subtraction;
        PrintDeligate printADD = AddResult;
        PrintDeligate printDiff = SubtractResult;
        // print += SubtractResult;
        int sum = add(3, 3);
        int diff = difference(3, 3);

        printADD(sum);
        printDiff(diff);



    }

    private static int Addition(int a, int b)
    {
        return a + b;
    }
    private static int Subtraction(int a, int b)
    {
        return a - b;
    }
    private static void AddResult(int result)
    {
        Console.WriteLine("The sum is " + result);
    }
    private static void SubtractResult(int result)
    {
        Console.WriteLine("The Subtract is " + result);
    }





}