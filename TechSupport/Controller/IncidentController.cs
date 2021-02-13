using System;
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
        public List<Incident> GetIncidents()
        {
            return this.database.GetIncidents();
        }

        /// <summary>
        /// Gets the incidents of this customer ID in the database as a List of Incidents
        /// </summary>
        /// <param name="customerID">Customer ID whose incidents are desired</param>
        /// <returns>The List of Incidents for this customer ID</returns>
        public List<Incident> GetIncidents(int customerID)
        {
            try
            {
                return this.database.GetIncidents(customerID);
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
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

        /// <see cref="IncidentSQLServerGetData.GetOpenIncidents"/>
        public List<OpenIncident> GetOpenIncidents()
        {
            return IncidentSQLServerGetData.GetOpenIncidents();
        }

        /// <see cref="IncidentSQLServerGetData.GetCustomers"/>
        public List<String> GetCustomers()
        {
            return IncidentSQLServerGetData.GetCustomers();
        }

        /// <see cref="IncidentSQLServerGetData.GetProducts"/>
        public List<String> GetProducts()
        {
            return IncidentSQLServerGetData.GetProducts();
        }

        /// <see cref="IncidentSQLServerModifyData.CreateIncident"/>
        public void CreateIncident(String customerName, String productName, String title, String description)
        {
            IncidentSQLServerModifyData.CreateIncident(customerName, productName, title, description);
        }
    }
}
