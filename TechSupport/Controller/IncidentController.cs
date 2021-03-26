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

        /// <see cref="IncidentDAL.GetOpenIncidents"/>
        public List<OpenIncident> GetOpenIncidents()
        {
            return IncidentDAL.GetOpenIncidents();
        }

        /// <see cref="CustomerDAL.GetCustomers"/>
        public List<Customer> GetCustomers()
        {
            return CustomerDAL.GetCustomers();
        }

        /// <see cref="ProductDAL.GetProducts"/>
        public List<Product> GetProducts()
        {
            return ProductDAL.GetProducts();
        }

        /// <see cref="IncidentDAL.CreateIncident(int, string, string, string)"/>
        public bool CreateIncident(NewIncident incident)
        {
            if (incident == null)
            {
                throw new ArgumentException("incident", "incident cannot be null");
            }
            return IncidentDAL.CreateIncident(incident.CustomerID, incident.ProductCode, incident.Title, incident.Description);
        }

        /// <see cref="RegistrationDAL.IsCustomerRegisteredToProduct(int, string)"/>
        public bool IsCustomerRegisteredToProduct(int customerID, string productCode)
        {
            return RegistrationDAL.IsCustomerRegisteredToProduct(customerID, productCode);
        }

        /// <see cref="IncidentDAL.GetIncident(int)"/>
        public OpenIncident GetIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            return IncidentDAL.GetIncident(incidentID);
        }

        /// <see cref="IncidentDAL.IsIncidentOpen(int)"/>
        public bool IsIncidentOpen(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            return IncidentDAL.IsIncidentOpen(incidentID);
        }

        /// <see cref="TechnicianDAL.GetTechnicians"/>
        public List<Technician> GetTechnicians()
        {
            return TechnicianDAL.GetTechnicians();
        }

        /// <see cref="IncidentDAL.HasIncidentBeenUpdatedSinceRetrieval(string)"/>
        public bool HasIncidentBeenUpdatedSinceRetrieval(string description)
        {
            return IncidentDAL.HasIncidentBeenUpdatedSinceRetrieval(description);
        }

        /// <see cref="IncidentDAL.CloseIncident(int)"/>
        public bool CloseIncident(int incidentID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            return IncidentDAL.CloseIncident(incidentID);
        }

        /// <see cref="IncidentDAL.UpdateIncident(int, string, int)"/>
        public bool UpdateIncident(int incidentID, string description, int? technicianID)
        {
            if (incidentID < 1)
            {
                throw new ArgumentException("IncidentID must be greater than 0");
            }
            if (technicianID < 1)
            {
                technicianID = null;
            }
            return IncidentDAL.UpdateIncident(incidentID, description, technicianID);
        }

        /// <see cref="IncidentDAL.GetOpenIncidentsByTechnician(int)"/>
        public List<Incident> GetIncidentsByTechnician(int techID)
        {
            if (techID < 1)
            {
                throw new ArgumentException("TechID must be greater than 0");
            }
            return IncidentDAL.GetOpenIncidentsByTechnician(techID);
        }
        /// <see cref="TechnicianDAL.GetTechnician(int)"/>
        public Technician GetTechnician(int techID)
        {
            if (techID < 1)
            {
                throw new ArgumentException("TechID must be greater than 0");
            }
            return TechnicianDAL.GetTechnician(techID);
        }

        /// <see cref="TechnicianDAL.GetTechniciansWhoHaveHandledOrAreHandlingIncidents" />
        public List<Technician> GetTechniciansWhoHaveHandledOrAreHandlingIncidents()
        {
            return TechnicianDAL.GetTechniciansWhoHaveHandledOrAreHandlingIncidents();
        }
    }
}
