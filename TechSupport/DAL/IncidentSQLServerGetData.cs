using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages various SQL Queries to the IncidentSQLServerConnection
    /// </summary>
    public class IncidentSQLServerGetData
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
                    "LEFT JOIN Technicians ON Incidents.TechID = Technicians.TechID";

            using (SqlConnection connection = IncidentSQLServerConnection.GetConnection())
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
                            OpenIncident incident = new OpenIncident(reader.GetString(ordProductCode),
                                reader.GetDateTime(ordDateOpened), reader.GetString(ordCustomer),
                                reader.GetString(ordTechnician), reader.GetString(ordTitle));
                            incidents.Add(incident);
                        }
                    }
                }
            }
            return incidents;
        }

        /// <summary>
        /// Sends a SQL Query to get a List of Customer Names from the TechSupport DB
        /// </summary>
        /// <returns>The List of Customer Names from TechSupport DB</returns>
        public static List<String> GetCustomers()
        {
            List<String> customers = new List<String>();
            String selectStatement = "SELECT Name FROM Products";
            using (SqlConnection connection = IncidentSQLServerConnection.GetConnection())
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

        /// <summary>
        /// Sends a SQL Query to get a List of Product Names from the TechSupport DB
        /// </summary>
        /// <returns>The List of Product Names from TechSupport DB</returns>
        public static List<String> GetProducts()
        {
            List<String> products = new List<String>();
            String selectStatement = "SELECT Name FROM Customers";
            using (SqlConnection connection = IncidentSQLServerConnection.GetConnection())
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
