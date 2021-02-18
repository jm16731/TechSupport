using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
        public static List<String> GetProducts()
        {
            List<String> products = new List<String>();
            String selectStatement = "SELECT Name FROM Products";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordName = reader.GetOrdinal("Name");
                        while (reader.Read())
                        {
                            products.Add(reader.GetString(ordName));
                        }
                    }
                }
            }
            return products;
        }
    }
}
