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
                    "Incidents.Title, Incidents.Description " +
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
                        int ordDescription = reader.GetOrdinal("Description");
                        while (reader.Read())
                        {
                            string tech = "";
                            if (!reader.IsDBNull(ordTechnician))
                            {
                                tech = reader.GetString(ordTechnician);
                            }
                            OpenIncident incident = new OpenIncident(reader.GetString(ordProductCode),
                                reader.GetDateTime(ordDateOpened), reader.GetString(ordCustomer),
                                tech, reader.GetString(ordTitle), reader.GetString(ordDescription));
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
        public static bool CreateIncident(int customerID, String productCode, String title, String description)
        {
            int rowsUpdated;
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("createIncident", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@ProductCode", productCode);
                    command.Parameters.AddWithValue("@Title", title);
                    command.Parameters.AddWithValue("@Description", description);

                    rowsUpdated = command.ExecuteNonQuery();
                }
            }
            if (rowsUpdated < 1)
            {
                return false;
            } else
            {
                return true;
            }
        }

        /// <summary>
        /// Returns the incident corresponding to the incidentID as an OpenIncident
        /// </summary>
        /// <param name="incidentID">id of the incident to retrieve</param>
        /// <returns>The desired incident as an OpenIncident</returns>
        public static OpenIncident GetIncident(int incidentID)
        {
            OpenIncident incident = null;
            String selectStatement = "SELECT Incidents.ProductCode AS[Product Code], CONVERT(date, Incidents.DateOpened) AS[Date Opened]," +
                    "Customers.Name AS Customer, Technicians.Name AS Technician, Incidents.Title, Incidents.Description" +
                "FROM Incidents" +
                    "JOIN Customers ON Incidents.CustomerID = Customers.CustomerID" +
                    "LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID" +
                    "WHERE Incidents.IncidentID = @incidentID";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@incidentID", incidentID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordProductCode = reader.GetOrdinal("Product Code");
                        int ordDateOpened = reader.GetOrdinal("Date Opened");
                        int ordCustomer = reader.GetOrdinal("Customer");
                        int ordTechnician = reader.GetOrdinal("Technician");
                        int ordTitle = reader.GetOrdinal("Title");
                        int ordDescription = reader.GetOrdinal("Description");
                        while (reader.Read())
                        {
                            string tech = "";
                            if (!reader.IsDBNull(ordTechnician))
                            {
                                tech = reader.GetString(ordTechnician);
                            }
                            incident = new OpenIncident(reader.GetString(ordProductCode),
                                reader.GetDateTime(ordDateOpened), reader.GetString(ordCustomer),
                                tech, reader.GetString(ordTitle), reader.GetString(ordDescription));
                        }
                    }
                }
            }
            return incident;
        }

        /// <summary>
        /// Returns whether or not an incident is truly open
        /// </summary>
        /// <param name="incidentID">The id of the incident to check</param>
        /// <returns>Whether or not said incident is open</returns>
        public static bool IsIncidentOpen(int incidentID)
        {
            bool open = false;
            String selectStatement = "SELECT CAST (CASE" +
                                        "WHEN DateClosed = null THEN 1" +
                                        "ELSE 0" +
                                        "END AS BIT) AS isOpen" +
                                    "FROM Incidents" +
                                    "WHERE Incidents.IncidentID = @incidentID;";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@incidentID", incidentID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            open = reader.GetBoolean(reader.GetOrdinal("isOpen"));
                        }
                    }
                }
            }
            return open;
        }

        /// <summary>
        /// Checks to see if an incident record has been changed since it was retrieved
        /// </summary>
        /// <param name="description">Description of the incident to check</param>
        /// <returns>If incident has been changed since retrieval</returns>
        public static bool HasIncidentBeenUpdatedSinceRetrieval(string description)
        {
            bool changed = true;
            String selectStatement = "SELECT Description, DateClosed" +
                                    "FROM Incidents" +
                                    "WHERE Description = @description;";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@description", description);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.IsDBNull(reader.GetOrdinal("DateClosed")))
                            {
                                changed = false;
                            }
                        }
                    }
                }
            }
            return changed;
        }

        public static bool CloseIncident(int incidentID)
        {
            int rowsUpdated;
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("closeIncident", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IncidentID", incidentID);

                    rowsUpdated = command.ExecuteNonQuery();
                }
            }
            if (rowsUpdated < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
