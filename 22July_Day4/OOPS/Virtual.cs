// // // public class Person
// // // {
// // //     public virtual string Identity()
// // //     {
// // //         return $"Hello Parent";
// // //     }
// // // }

// // // public class Student : Person
// // // {
// // //     public Student() : base(){}
// // //     public override string Identity()
// // //     {
// // //         Console.WriteLine($"Hello: {base.Identity()}");
// // //         return "0";
// // //     }
// // // }

// // // public class MainProgram
// // // {
// // //     public static void Main()
// // //     {
// // //         Person s1 = new Student();
// // //         s1.Identity();
// // //         Person p1 = new Person();
// // //         Console.WriteLine(p1.Identity());
// // //         Student s2 = new Student();
// // //         s2.Identity();
// // //     }
// // // }





// // public class Person
// // {
// //     public virtual string Identity()
// //     {
// //         return $"Hello Parent";
// //     }
// // }

// // public class Student : Person
// // {
// //     public Student() : base(){}
// //     public override string Identity()
// //     {
// //         Console.WriteLine($"Hello: {base.Identity()}");
// //         return "0";
// //     }
// // }

// // public class MainProgram
// // {
// //     public static void Main()
// //     {
// //         Person s1 = new Student();
// //         s1.Identity();
// //         Person p1 = new Person();
// //         Console.WriteLine(p1.Identity());
// //         Student s2 = new Student();
// //         s2.Identity();
// //     }
// // }





// public class Person
// {

//     public virtual void GetRole()
//     {

//         Console.WriteLine("Person class");

//     }

// }

// public class Teacher : Person
// {

//     //Generally it's overriden but you are hiding that method in the inherited class
//     public override void GetRole()
//     {

//         Console.WriteLine("She is a teacher");

//     }

// }

// public class Mother : Person
// {

//     //Generally it's overriden but you are hiding that method in the inherited class
//     public override void GetRole()
//     {

//         Console.WriteLine("She is a Mother");

//     }

// }

// public class MainProgram
// {

//     static void Main()
//     {
//         //Late Binding - RunTime Polymorphism
//         Person p = new Teacher();
//         Person p1 = new Mother();

//         p.GetRole();
//         p1.GetRole();
//     }
// }

// // both are having the Car() method but without virtual and override keyword it's not overriding -- they just hide 

