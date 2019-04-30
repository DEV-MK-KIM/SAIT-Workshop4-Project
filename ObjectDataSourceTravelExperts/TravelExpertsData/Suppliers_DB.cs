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
    }
}
