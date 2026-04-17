using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
namespace LabsSolutions.Lab12
{
    public class Program
    {
        public static void Main()
        {
            UseSqlite();
        }

        public static void UseSqlServer()
        {
            SqlConnection cn = new SqlConnection(
            @"Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;Encrypt=False");

            SqlCommand com = new SqlCommand("SELECT TOP 10 CustomerID, ContactName FROM customers", cn);
            cn.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " - " + dr[1]);
            }
            cn.Close();

            Console.WriteLine("Enter a CustomerID to search for:");
            string id = Console.ReadLine();
            cn.Open();
            com = new SqlCommand($"SELECT CustomerID, ContactName, ContactTitle, Address, City FROM customers WHERE CustomerID='{id}'", cn);
            try
            {
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["CustomerID"] + " - " + dr["ContactName"] + " - " + dr["ContactTitle"] + " - " + dr["Address"] + " - " + dr["City"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"No customer found with the id of {id}. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            cn.Open();
            com = new SqlCommand($"INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City) VALUES ('ABC01', 'ABC Trading Ltd', 'Janet Planet', 'Owner', '123 Main St', 'Anytown')", cn);
            try
            {
                int rowsAffected = com.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error inserting customer: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public static void UseSqlite()
        {
            SqliteConnection cn = new SqliteConnection("Data Source=northwind.db");
            cn.Open();

            string sql = @"
            SELECT CustomerID, CompanyName, ContactName, City, Country
            FROM Customers
            ORDER BY CompanyName";

            SqliteCommand com = new SqliteCommand(sql, cn);

            SqliteDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " - " + dr[1]);
            }
            cn.Close();

            Console.WriteLine("Enter a CustomerID to search for:");
            string id = Console.ReadLine();
            cn.Open();
            com = new SqliteCommand($"SELECT CustomerID, ContactName, ContactTitle, Address, City FROM customers WHERE CustomerID='{id}'", cn);
            try
            {
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["CustomerID"] + " - " + dr["ContactName"] + " - " + dr["ContactTitle"] + " - " + dr["Address"] + " - " + dr["City"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"No customer found with the id of {id}. " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            cn.Open();
            com = new SqliteCommand($"INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City) VALUES ('ABC01', 'ABC Trading Ltd', 'Janet Planet', 'Owner', '123 Main St', 'Anytown')", cn);
            try
            {
                int rowsAffected = com.ExecuteNonQuery();
                Console.WriteLine($"{rowsAffected} row(s) inserted.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error inserting customer: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}