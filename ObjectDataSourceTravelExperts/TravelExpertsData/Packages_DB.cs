using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    public static class Packages_DB
    {
        public static List<Packages> GetPackages()
        {
            List<Packages> packages = new List<Packages>();
            Packages pkg;

            using (SqlConnection connection = TravelExperts_DB.GetConnection())
            {
                string query = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                               "FROM Packages " +
                               "ORDER BY PackageID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        pkg = new Packages();

                        pkg.PackageID = (int)reader["PackageID"];
                        pkg.PkgName = reader["PkgName"].ToString();
                        pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];
                        pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];
                        pkg.PkgDesc = reader["PkgDesc"].ToString();
                        pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                        pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
                        packages.Add(pkg);
                        // packages

                    }
                    


                }




            }




                return packages;
        }

        public static Packages GetPackages(int pkgID)
        {
            Packages pkg = null;

            // create connection
            SqlConnection connection = TravelExperts_DB.GetConnection();

            //  create SELECT command
            string query = "SELECT CustomerID, Name, Address, City, State, ZipCode " + "FROM Customers " + "WHERE CustomerID = @CustomerID";
            SqlCommand cmd = new SqlCommand(query, connection);
            // supply perameter value after you have your command
            cmd.Parameters.AddWithValue("@CustomerID", custID);

            // run SELECT query
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                //build customer object to return
                if (reader.Read()) // if there is a customer with this ID
                {
                    cust = new Customer();
                    cust.CustomerID = (int)reader["CustomerID"];
                    cust.Name = reader["Name"].ToString();
                    cust.Address = reader["Address"].ToString();
                    cust.City = reader["City"].ToString();
                    cust.State = reader["State"].ToString();
                    cust.ZipCode = reader["ZipCode"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }


            return cust;
        }
    }
            
            
          

    }
}
