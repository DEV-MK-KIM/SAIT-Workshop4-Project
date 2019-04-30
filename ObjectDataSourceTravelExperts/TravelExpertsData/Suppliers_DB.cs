using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TravelExpertsData
{
    public static class Suppliers_DB
    {
        public static List<Suppliers> GetSuppliers()
        {
            List<Suppliers> suppliers = new List<Suppliers>();
            Suppliers spl;

            using (SqlConnection connection = TravelExperts_DB.GetConnection())
            {
                string query = "SELECT SupplierID, SupName " +
                               "ORDER BY SuppliersID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        spl = new Suppliers();

                        spl.SupplierID = (int)reader["SupplierID"];
                        spl.SupName = reader["SupName"].ToString();
                    }
                }
                return suppliers;
            }
        }
    }
}