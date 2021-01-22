using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// Gets the List of Incidents
        /// </summary>
        /// <returns></returns>
        public List<Incident> getIncidents()
        {
            return this.database.getIncidents();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="incident"></param>
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
