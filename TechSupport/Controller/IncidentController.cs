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

        /// <see cref="TechSupportSQLServerTableIncidents.GetOpenIncidents"/>
        public List<OpenIncident> GetOpenIncidents()
        {
            return TechSupportSQLServerTableIncidents.GetOpenIncidents();
        }

        /// <see cref="TechSupportSQLServerTableCustomers.GetCustomers"/>
        public List<Customer> GetCustomers()
        {
            return TechSupportSQLServerTableCustomers.GetCustomers();
        }

        /// <see cref="TechSupportSQLServerTableProducts.GetProducts"/>
        public List<Product> GetProducts()
        {
            return TechSupportSQLServerTableProducts.GetProducts();
        }

        /// <see cref="TechSupportSQLServerTableIncidents.CreateIncident(int, string, string, string)"/>
        public bool CreateIncident(int customerID, String productCode, String title, String description)
        {
            return TechSupportSQLServerTableIncidents.CreateIncident(customerID, productCode, title, description);
        }

        /// <see cref="TechSupportSQLServerTableRegistrations.IsCustomerRegisteredToProduct(int, string)"/>
        public bool IsCustomerRegisteredToProduct(int customerID, string productCode)
        {
            return TechSupportSQLServerTableRegistrations.IsCustomerRegisteredToProduct(customerID, productCode);
        }

        /// <see cref="TechSupportSQLServerTableIncidents.GetIncident(int)"/>
        public OpenIncident GetIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            return TechSupportSQLServerTableIncidents.GetIncident(incidentID);
        }

        /// <see cref="TechSupportSQLServerTableIncidents.IsIncidentOpen(int)"/>
        public bool IsIncidentOpen(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            return TechSupportSQLServerTableIncidents.IsIncidentOpen(incidentID);
        }

        /// <see cref="TechSupportSQLServerTableTechnicians.GetTechnicians"/>
        public List<Technician> GetTechnicians()
        {
            return TechSupportSQLServerTableTechnicians.GetTechnicians();
        }

        /// <see cref="TechSupportSQLServerTableIncidents.HasIncidentBeenUpdatedSinceRetrieval(string)"/>
        public bool HasIncidentBeenUpdatedSinceRetrieval(string description)
        {
            return TechSupportSQLServerTableIncidents.HasIncidentBeenUpdatedSinceRetrieval(description);
        }

        /// <see cref="TechSupportSQLServerTableIncidents.CloseIncident(int)"/>
        public bool CloseIncident(int incidentID)
        {
            return TechSupportSQLServerTableIncidents.CloseIncident(incidentID);
        }

        /// <see cref="TechSupportSQLServerTableIncidents.UpdateIncident(int, string, int)"/>
        public bool UpdateIncident(int incidentID, string description, int technicianID)
        {
            return TechSupportSQLServerTableIncidents.UpdateIncident(incidentID, description, technicianID);
        }
    }
}
