using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL queries to the Incidents table of the TechSupport db
    /// </summary>
    class IncidentDAL
    {
        /// <summary>
        /// Sends a SQL Query to get a List of Open Incidents from the TechSupport DB
        /// </summary>
        /// <returns>The List of Open Incidents from TechSupport DB</returns>
        public static List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> incidents = new List<OpenIncident>();
            String selectStatement = @"SELECT ProductCode,
                    CONVERT(date, DateOpened) AS [DateOpened],
                    Customers.Name AS Customer,
                    Technicians.Name AS Technician,
                    Title, Description
                FROM Incidents AS i
                    JOIN Customers ON i.CustomerID = Customers.CustomerID
                    LEFT JOIN Technicians ON i.TechID = Technicians.TechID
                    WHERE i.DateClosed IS NULL";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordProductCode = reader.GetOrdinal("ProductCode");
                        int ordDateOpened = reader.GetOrdinal("DateOpened");
                        int ordCustomer = reader.GetOrdinal("Customer");
                        int ordTechnician = reader.GetOrdinal("Technician");
                        int ordTitle = reader.GetOrdinal("Title");
                        int ordDescription = reader.GetOrdinal("Description");
                        while (reader.Read())
                        {
                            string tech = null;
                            if (!reader.IsDBNull(ordTechnician))
                            {
                                tech = reader.GetString(ordTechnician);
                            }
                            incidents.Add(new OpenIncident(reader.GetString(ordProductCode),
                                reader.GetDateTime(ordDateOpened), reader.GetString(ordCustomer),
                                tech, reader.GetString(ordTitle), reader.GetString(ordDescription)));
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
            using (SqlConnection connection = GetSQLConnection.GetConnection())
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
            String selectStatement = @"SELECT Incidents.ProductCode, CONVERT(date, Incidents.DateOpened) AS [DateOpened],
                    Customers.Name AS Customer, Technicians.Name AS Technician, Incidents.Title, Incidents.Description
                FROM Incidents
                    JOIN Customers ON Incidents.CustomerID = Customers.CustomerID
                    LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID
                    WHERE Incidents.IncidentID = @incidentID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@incidentID", incidentID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordProductCode = reader.GetOrdinal("ProductCode");
                        int ordDateOpened = reader.GetOrdinal("DateOpened");
                        int ordCustomer = reader.GetOrdinal("Customer");
                        int ordTechnician = reader.GetOrdinal("Technician");
                        int ordTitle = reader.GetOrdinal("Title");
                        int ordDescription = reader.GetOrdinal("Description");
                        while (reader.Read())
                        {
                            string tech = null;
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
            SqlParameter isOpen;
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("isIncidentOpen", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IncidentID", incidentID);

                    isOpen = new SqlParameter("@isOpen", System.Data.SqlDbType.Bit)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(isOpen);

                    command.ExecuteNonQuery();
                }
            }
            if (Convert.ToBoolean(isOpen.Value) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks to see if an incident record has been changed since it was retrieved
        /// </summary>
        /// <param name="description">Description of the incident to check</param>
        /// <returns>If incident has been changed since retrieval</returns>
        public static bool HasIncidentBeenUpdatedSinceRetrieval(string description)
        {
            bool changed = true;
            String selectStatement = @"SELECT Description, DateClosed
                                    FROM Incidents
                                    WHERE Description = @description;";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
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

        /// <summary>
        /// Closes an incident by setting a DateClosed value
        /// </summary>
        /// <param name="incidentID">The incident to close</param>
        /// <returns>Whether or not the operation succeeded</returns>
        public static bool CloseIncident(int incidentID)
        {
            int rowsUpdated;
            using (SqlConnection connection = GetSQLConnection.GetConnection())
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

        /// <summary>
        /// Updates an incidents by updating the given parameters
        /// </summary>
        /// <param name="incidentID">The id of the incident to update</param>
        /// <param name="description">The new description of the incident</param>
        /// <param name="technicianID">The id of the new technician of the incident</param>
        /// <returns>Whether or not the operation succeeded</returns>
        public static bool UpdateIncident(int incidentID, string description, int technicianID)
        {
            int rowsUpdated;
            String selectStatement = "UPDATE Incidents SET Description = @description, TechID = @technicianID WHERE IncidentID = @incidentID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@description", description);
                    command.Parameters.AddWithValue("@incidentID", incidentID);
                    command.Parameters.AddWithValue("@technicianID", technicianID);
                    connection.Open();
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

        /// <summary>
        /// Retrieves a list of incidents associated with a technician
        /// </summary>
        /// <param name="techID">ID of the technician whose incidents are desired</param>
        /// <returns>List of Incidents handled by said technician</returns>
        public static List<Incident> GetIncidentsByTechnician(int techID)
        {
            List<Incident> incidents = new List<Incident>();
            String selectStatement = @"SELECT i.IncidentID, c.Name AS CustomerName, p.Name AS ProductName, t.Name AS TechnicianName, 
                    i.DateOpened, i.DateClosed, i.Title, i.Description
                FROM Incidents AS i
	                JOIN Customers AS c ON i.CustomerID = c.CustomerID
	                JOIN Technicians AS t on i.TechID = t.TechID
	                JOIN Products AS p ON i.ProductCode = p.ProductCode
                WHERE i.techID = 11";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@techID", techID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordIncidentID = reader.GetOrdinal("IncidentID");
                        int ordCustomerName = reader.GetOrdinal("CustomerName");
                        int ordProductName = reader.GetOrdinal("ProductName");
                        int ordTechnicianName = reader.GetOrdinal("TechnicianName");
                        int ordDateOpened = reader.GetOrdinal("DateOpened");
                        int ordDateClosed = reader.GetOrdinal("DateClosed");
                        int ordTitle = reader.GetOrdinal("Title");
                        int ordDescription = reader.GetOrdinal("Description");
                        while (reader.Read())
                        {
                            DateTime? dateClosed = null;
                            if (!reader.IsDBNull(ordDateClosed))
                            {
                                dateClosed = reader.GetDateTime(ordDateClosed);
                            }
                            incidents.Add(new Incident(reader.GetInt32(ordIncidentID), reader.GetString(ordCustomerName),
                                reader.GetString(ordProductName), reader.GetString(ordTechnicianName), reader.GetDateTime(ordDateOpened),
                                dateClosed, reader.GetString(ordTitle), reader.GetString(ordDescription)));
                        }
                    }
                }
            }
            return incidents;
        }
    }
}
