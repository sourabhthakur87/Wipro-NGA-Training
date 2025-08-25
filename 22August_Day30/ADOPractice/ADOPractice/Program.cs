using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ADOPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.Connection();
            //Console.ReadLine();
        }
        static void Connection()
        {
            //string CS = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ado_db;Integrated Security=True";
        string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;


            SqlConnection con = new SqlConnection(CS);


            try 
            {

                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    Console.WriteLine("Enter id:");
                    string id = Console.ReadLine();
                    //Console.WriteLine("Enter Name:");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Enter Gender:");
                    //string gender = Console.ReadLine();
                    //Console.WriteLine("Enter Age:");
                    //string age = Console.ReadLine();
                    //Console.WriteLine("Enter Salary:");
                    //string salary = Console.ReadLine();
                    //Console.WriteLine("Enter City:");
                    //string city = Console.ReadLine();

                    //string query = "INSERT INTO employees (name, gender, age, salary, city) VALUES (@name, @gender, @age, @salary, @city)";
                    //string query = "update employees set name = @name, gender = @gender,age = @age,salary = @salary,city = @city where id = @id";
                    string query = "delete from employees where id = @id";


                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", id);
                    //cmd.Parameters.AddWithValue("@name", name);
                    //cmd.Parameters.AddWithValue("@gender", gender);
                    //cmd.Parameters.AddWithValue("@age", age);
                    //cmd.Parameters.AddWithValue("@salary", salary);
                    //cmd.Parameters.AddWithValue("@city", city);


                    int a = cmd.ExecuteNonQuery();

                    if (a > 0)
                    {
                        Console.WriteLine("Data Delete Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Data Not deleted");
                    }

                    //cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Console.WriteLine("Id: " + dr["id"] + " | Name: " + dr["name"] + " | Gender: " + dr["gender"] + " | Age: " + dr["age"]);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }



    }
}
