// using System;
// class Voter
// {
//     private int age;
//     public void SetAge(int age)
//     {
//         this.age = age;
//         if (this.age < 18)
//         {
//             Console.WriteLine("Age Should be greater than 18 ");
//         }
//         else
//         {
//             Console.WriteLine("Age is GOOD");
//         }
//     }
//     public int GetAge()
//     {
//         return age;
//     }
// }
// class MainProgram
// {

//     public static void Main()
//     {

//         Voter v = new Voter();
//         v.SetAge(19);
//         Console.WriteLine(v.GetAge());
//         // v.GetAge(18);
//     }

// }