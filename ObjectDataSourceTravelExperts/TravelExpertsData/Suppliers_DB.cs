using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class Suppliers_DB

    {
        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            Suppliers sup;

            using (SqlConnection connection = TravelExperts_DB.GetConnection())
            {
                string query = "SELECT SupplierID, SupName " +
                               "FROM Suppliers " +
                               "ORDER BY SupplierID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        sup = new Suppliers();

                        sup.SupplierID = (int)reader["SupplierID"];
                        sup.SupName = reader["SupName"].ToString();
                       
                        suppliers.Add(sup);

                    }
                }
            }

            return suppliers;
        }

        public static bool UpdateSuppliers(Suppliers oldSup, Suppliers newSup)
        {
            bool success = false; // did not update

            // connection
            using (SqlConnection con = TravelExperts_DB.GetConnection())
            // update command
            {
                string updateStatement =
                  "UPDATE Suppliers SET " +
                  " SupName = @NewSupName " + // Only Update SupplierName
                  "WHERE SupplierID = @OldSupplierID "+
                  " AND SupName = @OldSupName";
                  




                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                        cmd.Parameters.AddWithValue("@NewSupName", newSup.SupName);
                        cmd.Parameters.AddWithValue("@OldSupplierID", oldSup.SupplierID);
                        cmd.Parameters.AddWithValue("@OldSupName", oldSup.SupName);                      
                   
                    con.Open();

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        success = true;
                }
            }
            return success;
        }

        public static int AddSupplier(Suppliers sup)
        { 
            int supID = 0;

            // create connection
            SqlConnection connection = TravelExperts_DB.GetConnection();

            // create INSERT command
            // CustomerID is IDENTITY so no value provided
            // supplierID is not IDENTITY
            string insertStatement =
                "INSERT INTO Suppliers(SupplierID, SupName) " +
                "VALUES(@SupplierID, @SupName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
            cmd.Parameters.AddWithValue("@SupName", sup.SupName);
            
            try
            {
                connection.Open();

                // execute insert command and get inserted ID
                supID = (int)cmd.ExecuteScalar();
            
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return supID;
        }

       

    }
}
