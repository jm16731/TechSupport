﻿using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Controller for the TechSupport program
    /// </summary>
    public class IncidentController
    {
        private IncidentDatabase database;

        /// <summary>
        /// Creates an IncidentController with a new IncidentDatabase
        /// </summary>
        public IncidentController()
        {
            this.database = new IncidentDatabase();
        }

        /// <summary>
        /// Gets the incidents in the database as a List of Incidents
        /// </summary>
        /// <returns>The List Of Incidents</returns>
        public List<Incident> getIncidents()
        {
            return this.database.getIncidents();
        }

        /// <summary>
        /// Gets the incidents of this customer ID in the database as a List of Incidents
        /// </summary>
        /// <param name="customerID">Customer ID whose incidents are desired</param>
        /// <returns>The List of Incidents for this customer ID</returns>
        public List<Incident> getIncidents(int customerID)
        {
            return this.database.getIncidents(customerID);
        }

        /// <summary>
        /// Adds an Incident to the database
        /// </summary>
        /// <param name="incident">The incident to add to the database</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("incident", "Incident cannot be null");
            }
            this.database.Add(incident);
        }
    }
}
