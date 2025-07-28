class SchoolInvoice
{
    public delegate int Fee(int tuetionFee, int transportFee);
    public delegate void PrintInvoice(int result);

    public static void Main(string[] args)
    {
        Fee s1 = AddFee;
        int sum = s1(1200, 3000);
        PrintInvoice print = PrintAdd;
        print(sum);
    }

    private static int AddFee(int TFee, int TRFee)
    {
        return TFee + TRFee;
    }

    private static void PrintAdd(int result)
    {
        Console.WriteLine("The Total Fee is: " + result);
    }
}