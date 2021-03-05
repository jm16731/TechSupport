﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL queries to the Technicians table of the TechSupport db
    /// </summary>
    class TechnicianDAL
    {
        /// <summary>
        /// Returns a list of all technicians in the TechSupport db
        /// </summary>
        /// <returns>List of all technicians</returns>
        public static List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new List<Technician>();
            String selectStatement = "SELECT TechID, Name, Phone, Email FROM Technicians";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
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

        /// <summary>
        /// Gets a Technician by their TechID. May return null is no technician exists
        /// </summary>
        /// <param name="techID">ID of the technician to retrieve</param>
        /// <returns>The desired Technician</returns>
        public static Technician GetTechnician(int techID)
        {
            Technician tech = null;
            String selectStatement = "SELECT TechID, Name, Phone, Email FROM Technicians WHERE TechID = @techID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand(selectStatement, connection))
                {
                    command.Parameters.AddWithValue("@techID", techID);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        int ordID = reader.GetOrdinal("TechID");
                        int ordName = reader.GetOrdinal("Name");
                        int ordPhone = reader.GetOrdinal("Phone");
                        int ordEmail = reader.GetOrdinal("Email");
                        while (reader.Read())
                        {
                            tech = new Technician(reader.GetInt32(ordID), reader.GetString(ordName),
                                reader.GetString(ordPhone), reader.GetString(ordEmail));
                        }
                    }
                }
            }
            return tech;
        }

        /// <summary>
        /// Returns a list of technicians who are managing or have managed an incident
        /// </summary>
        /// <returns>A List of Technicians involved with past or present incidents</returns>
        public static List<Technician> GetTechniciansWhoHaveHandledOrAreHandlingIncidents()
        {
            List<Technician> technicians = new List<Technician>();
            String selectStatement = @"SELECT DISTINCT i.TechID, Name, Email, Phone
                FROM Technicians AS t
	                JOIN Incidents AS i ON t.TechID = i.TechID";
            using (SqlConnection connection = GetSQLConnection.GetConnection())
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
