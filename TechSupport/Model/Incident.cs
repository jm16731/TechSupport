using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an Incident in TechSupport
    /// </summary>
    public class Incident
    {
        public int IncidentID { get; }
        public string CustomerName { get; }
        public string ProductName { get; }
        public string TechName { get; }
        public DateTime DateOpened { get; }
        public DateTime? DateClosed { get; }
        public string Title { get; }
        public string Description { get; }

        public Incident(int incidentID, string customerName, string productName, string techName, DateTime dateOpened,
            DateTime? dateClosed, string title, string description)
        {
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(title) 
                || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(customerName))
            {
                throw new ArgumentException("productName " + "title " + "description " + "customer name", "Title, Description, " +
                    "ProductCode and CustomerName cannot be null or empty");
            }
            if (incidentID < 1)
            {
                throw new ArgumentException("incidentID " + "customerID " + "techID", "IDs cannot be less than 1");
            }
            if (dateOpened == null)
            {
                throw new ArgumentException("dateOpened", "DateOpened cannot be null");
            }

            this.IncidentID = incidentID;
            this.CustomerName = customerName;
            this.ProductName = productName;
            this.TechName = techName;
            this.DateOpened = dateOpened;
            this.DateClosed = dateClosed;
            this.Title = title;
            this.Description = description;
        }
    }
}
