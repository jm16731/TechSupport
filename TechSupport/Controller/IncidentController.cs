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
        public String CreateIncident(String customerName, String productName, String title, String description)
        {
            return IncidentSQLServerModifyData.CreateIncident(customerName, productName, title, description);
        }
    }
}
