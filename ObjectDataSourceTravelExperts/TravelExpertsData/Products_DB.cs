using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TravelExpertsData
{
    public static class Products_DB
    {
        // Done by Dingli 
        public static List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            Products prod;
            using (SqlConnection connection = TravelExperts_DB.GetConnection())
            {
                string query = "SELECT ProductID, ProdName " +
                               "FROM Products " +
                               "ORDER BY ProductID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        prod = new Products();
                        prod.ProductID = (int)reader["ProductID"];
                        prod.ProdName = reader["ProdName"].ToString();
                        products.Add(prod);
                    }
                }
            }
            return products;

        }

        public static int AddProducts(Products products)
        {
            throw new NotImplementedException();
        }

        public static int UpdateProducts(Products products, Products oldProducts)
        {
            throw new NotImplementedException();
        }
    }
}
