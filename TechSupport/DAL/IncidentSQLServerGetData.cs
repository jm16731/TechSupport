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
        public static List<Incident> getOpenIncidents()
        {
            List<Incident> incidents = new List<Incident>();
            SqlConnection connection = IncidentSQLServerConnection.GetConnection();
            String selectStatement = "SELECT Incidents.ProductCode AS [Product Code], " +
                    "CONVERT(date, Incidents.DateOpened) AS[Date Opened], " +
	                "Customers.Name, " +
	                "Technicians.Name, " +
	                "Incidents.Title " +
                "FROM Incidents " +
                    "JOIN Customers ON Incidents.CustomerID = Customers.CustomerID " +
                    "JOIN Technicians ON Incidents.TechID = Technicians.TechID";
            SqlCommand command = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Incident incident = new Incident();
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
        public static List<Invoice> GetInvoicesDue()
        {
            try
            {
                while (reader.Read())
                {
                    Invoice invoice = new Invoice();
                    invoice.InvoiceNumber = reader["InvoiceNumber"].ToString();
                    invoice.InvoiceDate = (DateTime)reader["InvoiceDate"];
                    invoice.InvoiceTotal = (decimal)reader["InvoiceTotal"];
                    invoice.PaymentTotal = (decimal)reader["PaymentTotal"];
                    invoice.CreditTotal = (decimal)reader["CreditTotal"];
                    invoice.DueDate = (DateTime)reader["DueDate"];
                    invoiceList.Add(invoice);
                }
            }
        }
    }
}
