using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an Incident in TechSupport
    /// </summary>
    public class Incident
    {
        public int IncidentID { get; }
        public int CustomerID { get; }
        public string ProductCode { get; }
        public int TechID { get; }
        public DateTime DateOpened { get; }
        public DateTime DateClosed { get; }
        public string Title { get; }
        public string Description { get; }

        public Incident(int incidentID, int customerID, string productCode, int techID, DateTime dateOpened,
            DateTime dateClosed, string title, string description)
        {
            if (string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("productCode " + "title " + "description", "Title, Description, " +
                    "and ProductCode cannot be null or empty");
            }
            if (incidentID < 1 || customerID < 1 || techID < 1)
            {
                throw new ArgumentException("incidentID " + "customerID " + "techID", "IDs cannot be less than 1");
            }
            if (dateOpened == null)
            {
                throw new ArgumentException("dateOpened", "DateOpened cannot be null");
            }

            this.IncidentID = incidentID;
            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.TechID = techID;
            this.DateOpened = dateOpened;
            this.DateClosed = dateClosed;
            this.Title = title;
            this.Description = description;
        }
    }
}
