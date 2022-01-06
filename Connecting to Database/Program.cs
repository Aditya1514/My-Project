using System;
using System.Data.SqlClient;


namespace Connecting_to_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            @"Data Source=ADITYA-CB-PC\SQLEXPRESS; Integrated Security=true; Initial Catalog = King";

            string command = "Select * from dbo.employee";

            using (SqlConnection conn=new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(command, conn);
                    using SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader[0]}, {reader[1]}, {reader[2]}");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
