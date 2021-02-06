using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentSQLServerGetData
    {
        public static List<OpenIncident> getOpenIncidents()
        {
            List<OpenIncident> incidents = new List<OpenIncident>();
            SqlConnection connection = IncidentSQLServerConnection.GetConnection();
            String selectStatement = "SELECT Incidents.ProductCode AS [Product Code], " +
                    "CONVERT(date, Incidents.DateOpened) AS[Date Opened], " +
	                "Customers.Name AS Customer, " +
	                "Technicians.Name AS Technician, " +
	                "Incidents.Title " +
                "FROM Incidents " +
                    "JOIN Customers ON Incidents.CustomerID = Customers.CustomerID " +
                    "JOIN Technicians ON Incidents.TechID = Technicians.TechID";
            SqlCommand command = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                int ordProductCode = reader.GetOrdinal("Product Code");
                int ordDateOpened = reader.GetOrdinal("Date Opened");
                int ordCustomer = reader.GetOrdinal("Customer");
                int ordTechnician = reader.GetOrdinal("Technician");
                int ordTitle = reader.GetOrdinal("Title");
                while (reader.Read())
                {
                    OpenIncident incident = new OpenIncident(reader.GetString(ordProductCode),
                        reader.GetString(ordDateOpened), reader.GetString(ordCustomer),
                        reader.GetString(ordTechnician), reader.GetString(ordTitle));
                    incidents.Add(incident);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return incidents;
        }
    }
}
