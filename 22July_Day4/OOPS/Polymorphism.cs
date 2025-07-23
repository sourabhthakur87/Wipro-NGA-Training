using System;

//The ability to take many forms 
/*method overloading -- where all methods in a class are with the same name
but the arguments will differ (either datatype will be different or the sequence of arguments are different or order of arguments are different)
static binding -- when compiler will identify which method
needs to be called at compile time*/

/*method overriding -- where some methods in base class and in inherited or child class are with the same name
run time  binding -- when compiler will identify which method
needs to be called at run time when the object will be created*/

// class InfoPrinter
// {
//     private int Pages;
//     InfoPrinter()
//     {
//         Console.WriteLine("Constructor Call");
//     }
//     InfoPrinter(int Page)
//     {
//         this.Pages = Page;
//         Pages = Pages + 1;

//         Console.WriteLine("Total Page Print : " + Pages);
//     }
//     public void Print(string name)
//     {
//         Console.WriteLine("Name: " + name);
//     }
//     public void Print(string name, int EmpID)
//     {
//         Console.WriteLine("Name: " + name + " EmpID: " + EmpID);
//     }


//     public static void Main()
//     {
//         InfoPrinter newprint = new InfoPrinter();
//         newprint.Print("Sourabh");
//         newprint.Print("Sourabh", 123);
//         InfoPrinter newprint1 = new InfoPrinter(23);
//         InfoPrinter newprint2 = new InfoPrinter(12);

//     }
// }