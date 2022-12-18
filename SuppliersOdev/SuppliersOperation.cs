using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliersOdev
{
    public class SuppliersOperation
    {
            SqlConnection cnn;
            SqlCommand cmd;

        public SuppliersOperation()
        {
            cnn = new SqlConnection(@"Server=.\sqlexpress; Database=Northwind; uid=sa;pwd=123");
        }

        public List<Suppliers> SuppList()
        {

          List<Suppliers> SuppList = new List<Suppliers>();

          cmd = new SqlCommand("select * from Suppliers", cnn);

          cnn.Open();
          SqlDataReader rdr = cmd.ExecuteReader();
          while (rdr.Read())
           {
                Suppliers supplier = new Suppliers();


                supplier.SupplierID = (int)rdr["SupplierID"];
                supplier.CompanyName = (string)rdr["CompanyName"];
                supplier.ContactName = (string)rdr["ContactName"];
                supplier.ContactTitle = (string)rdr["ContactTitle"];
                supplier.Address = (string)rdr["Address"];
                

               SuppList.Add(supplier);

           }
              cnn.Close();
              return SuppList;
         }
              public int Add(Suppliers ship)
                {
                cmd = new SqlCommand("insert Suppliers (CompanyName,ContactName,ContactTitle,Address) values (@CompanyName, @ContactName, @ContactTitle, @Address)", cnn);
                cmd.Parameters.AddWithValue("CompanyName", ship.CompanyName);
                cmd.Parameters.AddWithValue("@ContactName", ship.ContactName);
                cmd.Parameters.AddWithValue("@ContactTitle", ship.ContactTitle);
                cmd.Parameters.AddWithValue("@Address", ship.Address);

            cnn.Open();
            int returnVal = cmd.ExecuteNonQuery();
            cnn.Close();

            return returnVal;


        }


        }
    }