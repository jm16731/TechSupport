using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL queries to the Incidents table of the TechSupport db
    /// </summary>
    class TechSupportSQLServerTableIncidents
    {
        /// <summary>
        /// Sends a SQL Query to get a List of Open Incidents from the TechSupport DB
        /// </summary>
        /// <returns>The List of Open Incidents from TechSupport DB</returns>
        public static List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> incidents = new List<OpenIncident>();
            String selectStatement = "SELECT Incidents.ProductCode AS [Product Code], " +
                    "CONVERT(date, Incidents.DateOpened) AS[Date Opened], " +
                    "Customers.Name AS Customer, " +
                    "Technicians.Name AS Technician, " +
                    "Incidents.Title " +
                "FROM Incidents " +
                    "JOIN Customers ON Incidents.CustomerID = Customers.CustomerID " +
                    "LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID" +
                    "WHERE Incidents.DateClosed IS NULL";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordProductCode = reader.GetOrdinal("Product Code");
                        int ordDateOpened = reader.GetOrdinal("Date Opened");
                        int ordCustomer = reader.GetOrdinal("Customer");
                        int ordTechnician = reader.GetOrdinal("Technician");
                        int ordTitle = reader.GetOrdinal("Title");
                        while (reader.Read())
                        {
                            string tech = "";
                            if (!reader.IsDBNull(ordTechnician))
                            {
                                tech = reader.GetString(ordTechnician);
                            }
                            OpenIncident incident = new OpenIncident(reader.GetString(ordProductCode),
                                reader.GetDateTime(ordDateOpened), reader.GetString(ordCustomer),
                                tech, reader.GetString(ordTitle));
                            incidents.Add(incident);
                        }
                    }
                }
            }
            return incidents;
        }


        /// <summary>
        /// Inserts a new Incident into the TechSupport DB
        /// </summary>
        /// <param name="customerID">The id of customer whose incident it is</param>
        /// <param name="productCode">The product code of the incident's product</param>
        /// <param name="title">Title describing the incident</param>
        /// <param name="description">Explanation of the incident</param>
        /// <returns>A string message stating if the operation was successful or what went wrong</returns>
        public static String CreateIncident(int customerID, String productCode, String title, String description)
        {
            SqlParameter message;
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("createIncident", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerName", customerID);
                    command.Parameters.AddWithValue("@ProductName", productCode);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    message = new SqlParameter("@message", System.Data.SqlDbType.VarChar, 100)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(message);

                    command.ExecuteNonQuery();
                }
            }
            return message.Value.ToString();
        }
    }
}
