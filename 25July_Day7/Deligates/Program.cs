// using System;

// class ABC
// {

//     // public static void Print(int a)
//     // {
//     //     Console.WriteLine(a);
//     // }
//     // public static void Print1()
//     // {
//     //     Console.WriteLine("This is the Print1");
//     // }
//     // public static void Print2()
//     // {
//     //     Console.WriteLine("This is the Print-2");
//     // }


//     public static int Addnumbers(int x, int y)
//     {
//         return x + y;
//     }
//     public static void PrintResult(int result)
//     {
//         Console.WriteLine(result);
//     }
// }
// class MainProgram
// {
//     // public delegate void MyShow(int a);
//     // public delegate void MyShow1();

//     public delegate int ADD(int a, int b);
//     public delegate void Print(int result);

//     public static void Main(string[] args)
//     {
//         // MyShow nw = ABC.Print;
//         // MyShow1 nw1 = ABC.Print1;
//         // MyShow1 nw2 = ABC.Print2;
//         // nw(1);
//         // nw1();
//         // nw2();

//         ADD addnumber = ABC.Addnumbers;
//         Print pp = ABC.PrintResult;
//         int sum = addnumber(1, 2);
//         pp(sum);

//     }


// }