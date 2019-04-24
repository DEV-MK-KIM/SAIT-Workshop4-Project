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
            
            
          

    }
}
