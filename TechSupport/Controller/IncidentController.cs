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

        /// <see cref="TechSupportSQLServerTableIncidents.CreateIncident"/>
        public bool CreateIncident(int customerID, String productCode, String title, String description)
        {
            return TechSupportSQLServerTableIncidents.CreateIncident(customerID, productCode, title, description);
        }

        /// see cref="TechSupportSQLServerTableRegistrations.isCustomerRegisteredToProduct"/>
        public bool IsCustomerRegisteredToProduct(int customerID, string productCode)
        {
            return TechSupportSQLServerTableRegistrations.IsCustomerRegisteredToProduct(customerID, productCode);
        }
    }
}
