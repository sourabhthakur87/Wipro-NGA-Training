using System;
using System.Configuration;
using System.Data.SqlClient;

namespace ADOCRUDPractice
{
    public class Program
    {

        static string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        static void Main(string[] args)
        {
            Program.GetData();
            //Program.AddData();
            //Program.UpdateData();
            //Program.DeleteEmployee();
        }

        static void GetData()
        {

            using (SqlConnection con = new SqlConnection(CS))
            {



                con.Open();

                string query = "select * from employees";
                SqlCommand cmd = new SqlCommand(query, con);

                SqlDataReader dr = cmd.ExecuteReader();


                //Console.WriteLine(dr.HasRows);
                //Console.WriteLine(dr.IsClosed);

                //console.writeline(dr.getname(2));




                //while (dr.Read())
                //{
                //    Console.WriteLine("Id: " + dr["id"] + " | Name: " + dr["name"] + " | Gender: " + dr["gender"] + " | Age: " + dr["age"]);

                //}


            }

        }


        static void AddData()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();


                var emp = ReadEmployeeDetails();


                string query = "insert into employees values(@name,@gender,@age,@salary,@city)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", emp.name);
                cmd.Parameters.AddWithValue("@gender", emp.gender);
                cmd.Parameters.AddWithValue("@age", emp.age);
                cmd.Parameters.AddWithValue("@salary", emp.salary);
                cmd.Parameters.AddWithValue("@city", emp.city);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    Console.WriteLine("Data Inserted Success");

                    Console.WriteLine("-----------------------------------------------------------------------");
                    GetData();
                }
                else
                {
                    Console.WriteLine("Something Went Wrong");
                }

            }

        }

        static void UpdateData()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();



                Console.WriteLine("Enter id to Update: ");
                string id = Console.ReadLine();
                var emp = ReadEmployeeDetails();


                string query = "update employees set name = @name,gender = @gender,age = @age,salary = @salary,city = @city where id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", emp.name);
                cmd.Parameters.AddWithValue("@gender", emp.gender);
                cmd.Parameters.AddWithValue("@age", emp.age);
                cmd.Parameters.AddWithValue("@salary", emp.salary);
                cmd.Parameters.AddWithValue("@city", emp.city);

                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    Console.WriteLine("Data Updated Success");
                    Console.WriteLine("-----------------------------------------------------------------------");

                    GetData();
                }
                else
                {
                    Console.WriteLine("Something Went Wrong");
                }
            }
        }

        static void DeleteEmployee()
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                Console.WriteLine("Enter id to Delete Employee: ");
                string id = Console.ReadLine();


                string query = "delete from employees where id = @id";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id", id);


                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    Console.WriteLine("Employee Deleted Success");
                    Console.WriteLine("-----------------------------------------------------------------------");

                    GetData();
                }
                else
                {
                    Console.WriteLine("Something Went Wrong");
                }
            }
        }

        static dynamic ReadEmployeeDetails()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("Enter City: ");
            string city = Console.ReadLine();

            return new { name, gender, age, salary, city };
        }
    }
}






//namespace ADOCRUDPractice
//{
//    public class Program
//    {
//        static string CS => ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

//        static void Main(string[] args)
//        {
//            GetData();
//             AddData();
//            // UpdateData();
//            //DeleteEmployee();d
//        }

//        static void GetData()
//        {
//            using (SqlConnection con = new SqlConnection(CS))
//            {
//                con.Open();
//                string query = "SELECT * FROM employees";
//                using (SqlCommand cmd = new SqlCommand(query, con))
//                using (SqlDataReader dr = cmd.ExecuteReader())
//                {
//                    while (dr.Read())
//                    {
//                        Console.WriteLine($"Id: {dr["id"]} | Name: {dr["name"]} | Gender: {dr["gender"]} | Age: {dr["age"]}");
//                    }
//                }
//            }
//        }

//        static void AddData()
//        {
//            Console.WriteLine("------------------------------------------------------------------------");
//            Console.WriteLine("Enter Data To Add");
//            var emp = ReadEmployeeDetails();

//            string query = "INSERT INTO employees (name, gender, age, salary, city) VALUES (@name, @gender, @age, @salary, @city)";
//            int rowsAffected = ExecuteNonQuery(query, emp);

//            Console.WriteLine(rowsAffected > 0 ? "Data Inserted Successfully" : "Insertion Failed");
//            if (rowsAffected > 0) GetData();
//        }

//        static void UpdateData()
//        {
//            Console.Write("Enter ID to Update: ");
//            int id = int.Parse(Console.ReadLine());
//            var emp = ReadEmployeeDetails();
//            emp.id = id;

//            string query = @"UPDATE employees SET name = @name, gender = @gender, age = @age, salary = @salary, city = @city WHERE id = @id";
//            int rowsAffected = ExecuteNonQuery(query, emp);

//            Console.WriteLine(rowsAffected > 0 ? "Data Updated Successfully" : "Update Failed");
//            if (rowsAffected > 0) GetData();
//        }

//        static void DeleteEmployee()
//        {
//            Console.Write("Enter ID to Delete: ");
//            int id = int.Parse(Console.ReadLine());

//            string query = "DELETE FROM employees WHERE id = @id";
//            int rowsAffected = ExecuteNonQuery(query, new { id });

//            Console.WriteLine(rowsAffected > 0 ? "Employee Deleted Successfully" : "Deletion Failed");
//            if (rowsAffected > 0) GetData();
//        }

//        // Reusable method to execute Insert/Update/Delete
//        static int ExecuteNonQuery(string query, dynamic emp)
//        {
//            using (SqlConnection con = new SqlConnection(CS))
//            using (SqlCommand cmd = new SqlCommand(query, con))
//            {
//                con.Open();

//                if (query.Contains("@id")) cmd.Parameters.AddWithValue("@id", emp.id);
//                cmd.Parameters.AddWithValue("@name", emp.name);
//                cmd.Parameters.AddWithValue("@gender", emp.gender);
//                cmd.Parameters.AddWithValue("@age", emp.age);
//                cmd.Parameters.AddWithValue("@salary", emp.salary);
//                cmd.Parameters.AddWithValue("@city", emp.city);

//                return cmd.ExecuteNonQuery();
//            }
//        }

//        // Collect employee details from user
//        static dynamic ReadEmployeeDetails()
//        {
//            Console.Write("Enter Name: ");
//            string name = Console.ReadLine();
//            Console.Write("Enter Gender: ");
//            string gender = Console.ReadLine();
//            Console.Write("Enter Age: ");
//            int age = int.Parse(Console.ReadLine());
//            Console.Write("Enter Salary: ");
//            decimal salary = decimal.Parse(Console.ReadLine());
//            Console.Write("Enter City: ");
//            string city = Console.ReadLine();

//            return new { name, gender, age, salary, city };
//        }
//    }
//}

