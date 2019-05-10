using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{// Author: Lee Neufeld
    public static class Packages_DB
    {
        public static List<Packages> GetAllPackages()
        {
            List<Packages> packages = new List<Packages>();
            Packages pkg;

            SqlConnection connection = TravelExperts_DB.GetConnection();

            string query = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " +
                               "FROM Packages " +
                               "ORDER BY PackageID";
            SqlCommand cmd = new SqlCommand(query, connection);



            connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        pkg = new Packages();
                        pkg.PackageID = (int)reader["PackageID"];
                        pkg.PkgName = reader["PkgName"].ToString();

                        int col1 = reader.GetOrdinal("PkgStartDate");
                        if (reader.IsDBNull(col1)) pkg.PkgStartDate = null;
                        else pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];

                        int col2 = reader.GetOrdinal("PkgEndDate");
                        if (reader.IsDBNull(col2)) pkg.PkgEndDate = null;
                        else pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];

                        pkg.PkgDesc = reader["PkgDesc"].ToString();
                        pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];

                        int col3 = reader.GetOrdinal("PkgAgencyCommission");
                        if (reader.IsDBNull(col3)) pkg.PkgAgencyCommission = null;
                        else pkg.PkgAgencyCommission = (Decimal)reader["PkgAgencyCommission"];
                        packages.Add(pkg);
                      

                    }
                    
                return packages;
        }
      
        public static Packages GetPackages(int pkgID)
        {
            Packages pkg = null;

            // create connection
            SqlConnection connection = TravelExperts_DB.GetConnection();

            //  create SELECT command
            string query = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " + "FROM Packages " + "WHERE PackageID = @PackageID";
            SqlCommand cmd = new SqlCommand(query, connection);
            // supply perameter value after you have your command
            cmd.Parameters.AddWithValue("@PackageID", pkgID);

            // run SELECT query
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);

                //build package object to return
                if (reader.Read()) // if there is a package with this ID
                {
                    pkg = new Packages();
                    pkg.PackageID = (int)reader["PackageID"];
                    pkg.PkgName = reader["PkgName"].ToString();
                    pkg.PkgStartDate = (DateTime)reader["PkgStartDate"];
                    pkg.PkgEndDate = (DateTime)reader["PkgEndDate"];
                    pkg.PkgDesc = reader["PkgDesc"].ToString();
                    pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pkg.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];
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


            return pkg;
        }
        // insert new row to packages table
        // return new package ID
        public static int AddPackage(Packages pkg)
        {
            int pkgID = 0;
            // create connection

            SqlConnection connection = TravelExperts_DB.GetConnection();


            // create INSERT command
            // package ID is identity so there is no value provideed it is auto generated
            string insertStatement = "INSERT INTO Packages(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                "OUTPUT inserted.PackageID " +
                "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission) ";
            SqlCommand cmd = new SqlCommand(insertStatement, connection);
            cmd.Parameters.AddWithValue("@PkgName", pkg.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", pkg.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", pkg.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", pkg.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", pkg.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", pkg.PkgAgencyCommission);
            try
            {
                connection.Open();

                // execute INSERT command
                pkgID = (int)cmd.ExecuteScalar();
         

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return pkgID;

        }

       

        //update package and return if successful
        public static bool UpdatePackage(Packages oldPkg, Packages newPkg)
        {
            bool success = false;
            //create connection
            SqlConnection connection = TravelExperts_DB.GetConnection();
            // create UPDATE command
            string updateStatement =
                "UPDATE Packages SET " +
                "PkgName = @NewPkgName, " +
                "PkgStartDate = @NewPkgStartDate, " +
                "PkgEndDate =  @NewPkgEndDate, " +
                "PkgDesc = @NewPkgDesc, " +
                "PkgBasePrice = @NewPkgBasePrice, " +
                "PkgAgencyCommission = @NewPkgAgencyCommission " +
                "WHERE PackageID = @OldPackageID " +// indentifies the packages
                "AND PkgName = @OldPkgName " + // remaing concurrentcy
                "AND PkgStartDate = @OldPkgStartDate " +
                "AND PkgEndDate = @OldPkgEndDate " +
                "AND PkgDesc = @OldPkgDesc " +
                "AND PkgBasePrice = @OldPkgBasePrice " +
                "AND PkgAgencyCommission = @OldPkgAgencyCommission ";
            SqlCommand cmd = new SqlCommand(updateStatement, connection);
            cmd.Parameters.AddWithValue("@NewPkgName", newPkg.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPkg.PkgStartDate);
            cmd.Parameters.AddWithValue("@NewPkgEndDate", newPkg.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPkg.PkgDesc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPkg.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPkg.PkgAgencyCommission);
            cmd.Parameters.AddWithValue("@OldPackageID", oldPkg.PackageID);
            cmd.Parameters.AddWithValue("@OldPkgName", oldPkg.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPkg.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPkg.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPkg.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPkg.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPkg.PkgAgencyCommission);

            try
            {
                connection.Open();
                int count = cmd.ExecuteNonQuery();
                if (count > 0)
                {
                    success = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return success;
        }
    }
            
            
   

    }

