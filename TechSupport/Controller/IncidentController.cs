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
        public bool CreateIncident(int customerID, String productCode, String title, String description)
        {
            return IncidentDAL.CreateIncident(customerID, productCode, title, description);
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
        public bool UpdateIncident(int incidentID, string description, int technicianID)
        {
            if (incidentID < 1 || technicianID < 1)
            {
                throw new ArgumentException("IncidentID and TechnicianID must be greater than 0");
            }
            return IncidentDAL.UpdateIncident(incidentID, description, technicianID);
        }
    }
}
