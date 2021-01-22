using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// A mock-up of a DAL. Maintains a List of Incidents
    /// </summary>
    public class IncidentDatabase
    {
        private static List<Incident> _incidents = new List<Incident>
        {
            new Incident("Bing Virus", "Google keeps using this thing called Bing. Is that a virus?", 1),
            new Incident("Printer On Fire", "It's on fire! Oh dear God!", 101)
         };

        /// <summary>
        /// Gets the List of Incidents
        /// </summary>
        /// <returns>List of Incidents</returns>
        public List<Incident> getIncidents()
        {
            return _incidents;
        }

        /// <summary>
        /// Gets a List of Incidents that only involve the given customer ID
        /// </summary>
        /// <param name="customerID">The customer ID of the customer's whose Incidents you wish to return</param>
        /// <returns>List of Incidents only for the given customer ID</returns>
        public List<Incident> getIncidents(int customerID)
        {
            List<Incident> incidentsByCusomterID = new List<Incident>();
            foreach (Incident incident in _incidents)
            {
                if (incident.CustomerID == customerID)
                {
                    incidentsByCusomterID.Add(incident);
                }
            }
            return incidentsByCusomterID;
        }

        /// <summary>
        /// Adds an Incident to the List of Incidents
        /// </summary>
        /// <param name="incident">The Incident to add to the List of Incidents</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("incident", "Incident cannot be null");
            }
            _incidents.Add(incident);
        }
    }
}
