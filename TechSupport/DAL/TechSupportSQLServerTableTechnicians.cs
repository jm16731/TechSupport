using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class TechSupportSQLServerTableTechnicians
    {
        /// <summary>
        /// Returns a list of all technicians in the TechSupport db
        /// </summary>
        /// <returns>List of all technicians</returns>
        public static List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();
            String selectStatement = "SELECT TechID, Name, Phone, Email FROM Technicians";
            using (SqlConnection connection = TechSupportSQLServerGetConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("TechID");
                        int ordName = reader.GetOrdinal("Name");
                        int ordPhone = reader.GetOrdinal("Phone");
                        int ordEmail = reader.GetOrdinal("Email");
                        while (reader.Read())
                        {
                            technicians.Add(new Technician(reader.GetInt32(ordID), reader.GetString(ordName),
                                reader.GetString(ordPhone), reader.GetString(ordEmail)));
                        }
                    }
                }
            }
            return technicians;
        }
    }
}
