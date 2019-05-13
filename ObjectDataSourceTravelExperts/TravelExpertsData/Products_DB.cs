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

        public static int AddProducts(Products prod)
        {
            int prodID = 0;
            // create connection
            SqlConnection connection = TravelExperts_DB.GetConnection();
            string insertStatement =
                "INSERT INTO Products(ProductID, ProdName) " +
                "VALUES(@ProductID, @ProdName)";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@ProductID", prod.ProductID);
            cmd.Parameters.AddWithValue("@ProdName", prod.ProdName);
            int count = 0;
            try
            {
                connection.Open();
                // execute insert command and get inserted ID
                count = (int)cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return prodID;
        }

        public static bool UpdateProducts(Products oldProd, Products newProd)
        {
            bool success = false; // did not update

            // connection
            using (SqlConnection con = TravelExperts_DB.GetConnection())
            // update command
            {
                string updateStatement =
                  "UPDATE Products SET " +
                  " ProdName = @NewProdName " + // Only Update ProductName
                  "WHERE ProductID = @OldProductID "; //+" AND ProdName = @OldProdName";

                using (SqlCommand cmd = new SqlCommand(updateStatement, con))
                {
                    cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
                    cmd.Parameters.AddWithValue("@OldProductID", oldProd.ProductID);
                    cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);

                    con.Open();

                    int count = cmd.ExecuteNonQuery();
                    if (count > 0)
                        success = true;
                }
            }
            return success;
        }

        //Created by Mohmaed to display all packages
        public static DataTable GetAllPackages()

        {
            DataTable pkgtable = new DataTable();

            SqlConnection conn = TravelExperts_DB.GetConnection();
            conn.Open();
            try
            {
              
                string statement = "select s.SupName, pk.pkgname, " +
                    "p.prodname from Suppliers s, Packages pk, " +
                    "Packages_Products_Suppliers pps, Products_Suppliers ps, products p " +
                    "where pk.PackageId = pps.PackageId and pps.ProductSupplierId = ps.ProductSupplierId " +
                    "and ps.SupplierId = s.SupplierId and p.ProductId = ps.ProductId";
                SqlCommand comm = new SqlCommand(statement, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(pkgtable);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }


            return pkgtable;

        }


    }
}
