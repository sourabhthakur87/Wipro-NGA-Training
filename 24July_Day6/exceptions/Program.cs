using System.IO;
class Exceprion
{
    public static void Main()
    {
        // try
        // {
        //     int a = 10;
        //     int b = 10;
        //     int result = a / b;
        //     Console.WriteLine(result);
        //     int[] arr = { 1, 2, 5, 3, 6, 7 };

        //     for (int i = 0; i < arr.Length + 1; i++)
        //     {
        //         Console.Write(arr[i] + "  ");
        //     }
        // }


        // catch (Exception e)
        // {
        //     Console.WriteLine(e.Message);
        //     Console.WriteLine("Cannot divide by zero");
        // }


        // catch (IndexOutOfRangeException e)
        // {
        //     Console.WriteLine();

        //     Console.WriteLine(e.Message);
        //     Console.WriteLine("Index Out Of Range");
        // }

        // Console.WriteLine("Next Statement");







        // ---------------------------------------




        try
        {

            string fpath = "hello.txt";
            using (StreamReader reader = new StreamReader(fpath))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
        }
        catch (FileNotFoundException ex)
        {

            Console.WriteLine("File Not Found");
        }

    }
}
