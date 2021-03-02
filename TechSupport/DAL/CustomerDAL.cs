using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL Queries to the Customers table of the TechSupport db
    /// </summary>
    public class CustomerDAL
    {
        /// <summary>
        /// Sends a SQL Query to get a List of Customer Names from the TechSupport DB
        /// </summary>
        /// <returns>The List of Customer Names from TechSupport DB</returns>
        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            String selectStatement = "SELECT CustomerID, Name, Address, City, State, ZipCode, Phone, Email FROM Customers";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("CustomerID");
                        int ordName = reader.GetOrdinal("Name");
                        int ordAddress = reader.GetOrdinal("Address");
                        int ordCity = reader.GetOrdinal("City");
                        int ordState = reader.GetOrdinal("State");
                        int ordZip = reader.GetOrdinal("ZipCode");
                        int ordPhone = reader.GetOrdinal("Phone");
                        int ordEmail = reader.GetOrdinal("Email");
                        while (reader.Read())
                        {
                            string phone = null;
                            string email = null;
                            if (!reader.IsDBNull(ordPhone))
                            {
                                phone = reader.GetString(ordPhone);
                            }
                            if (!reader.IsDBNull(ordEmail))
                            {
                                email = reader.GetString(ordEmail);
                            }
                            customers.Add(new Customer(reader.GetInt32(ordID), reader.GetString(ordName),
                                reader.GetString(ordAddress), reader.GetString(ordCity), reader.GetString(ordState),
                                reader.GetString(ordZip), phone, email));
                        }
                    }
                }
            }
            return customers;
        }
    }
}
