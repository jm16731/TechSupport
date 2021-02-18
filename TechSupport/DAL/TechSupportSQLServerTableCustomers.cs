using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL Queries to the Customers table of the TechSupport db
    /// </summary>
    public class TechSupportSQLServerTableCustomers
    {
        /// <summary>
        /// Sends a SQL Query to get a List of Customer Names from the TechSupport DB
        /// </summary>
        /// <returns>The List of Customer Names from TechSupport DB</returns>
        public static List<String> GetCustomers()
        {
            List<String> customers = new List<String>();
            String selectStatement = "SELECT Name FROM Customers";
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
                            customers.Add(reader.GetString(ordName));
                        }
                    }
                }
            }
            return customers;
        }
    }
}
