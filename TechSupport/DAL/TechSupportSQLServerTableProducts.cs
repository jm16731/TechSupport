using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL queries to the Products table of the TechSupport db
    /// </summary>
    class TechSupportSQLServerTableProducts
    {
        /// <summary>
        /// Sends a SQL Query to get a List of Product Names from the TechSupport DB
        /// </summary>
        /// <returns>The List of Product Names from TechSupport DB</returns>
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            String selectStatement = "SELECT ProductCode AS [Product Code], Name, Version, ReleaseDate AS [Release Date] FROM Products";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordCode = reader.GetOrdinal("Product Code");
                        int ordName = reader.GetOrdinal("Name");
                        int ordVersion = reader.GetOrdinal("Version");
                        int ordRelease = reader.GetOrdinal("Release Date");
                        while (reader.Read())
                        {
                            products.Add(new Product(reader.GetString(ordCode), reader.GetString(ordName),
                                reader.GetDecimal(ordVersion), reader.GetDateTime(ordRelease)));
                        }
                    }
                }
            }
            return products;
        }
    }
}
