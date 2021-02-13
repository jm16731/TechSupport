using System;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages various add, insert, update, or delete SQL Queries 
    /// to the IncidentSQLServerConnection
    /// </summary>
    class IncidentSQLServerModifyData
    {
        /// <summary>
        /// Inserts a new Incident into the TechSupport DB
        /// </summary>
        /// <param name="customerName">The customer whose incident it is</param>
        /// <param name="productName">The product of the incident</param>
        /// <param name="title">Title describing the incident</param>
        /// <param name="description">Explanation of the incident</param>
        /// <returns>A string message stating if the operation was successful or what went wrong</returns>
        public static String CreateIncident(String customerName, String productName, String title, String description)
        {
            SqlParameter message;
            using (SqlConnection connection = IncidentSQLServerConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("createIncident", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    message = new SqlParameter("@message", System.Data.SqlDbType.VarChar, 100);
                    message.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(message);

                    command.ExecuteNonQuery();
                }
            }
            return message.Value.ToString();
        }
    }
}
