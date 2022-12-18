using System.Data.SqlClient;

namespace odev
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlConnection cnn = new SqlConnection();

            cnn.ConnectionString = @"Server=.\sqlexpress; Database=Northwind; uid=sa;pwd=123";

            cnn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select * from Shippers";
            cmd.Connection = cnn;

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {

                Console.WriteLine($"{rdr[0]} {rdr[1]} {rdr[2]}");

            }


            cnn.Close();


            // BU ALANI AdoNet'i TEKRAR ETMEK İÇİN OLUŞTURDUM TEKRAR YAZDIM (local pc sql ismi \sqlexpress)

        }
    }
}