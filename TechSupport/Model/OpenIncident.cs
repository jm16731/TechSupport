using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an OpenIncident being managed by TechSupport
    /// </summary>
    public class OpenIncident
    {
        public string ProductCode { get; }
        public DateTime DateOpened { get; }
        public string CustomerName { get; }
        public string TechnicianName { get; }
        public string Title { get; }
        public string Description { get; }

        /// <summary>
        /// Creates an OpenIncident according to the given parameters
        /// </summary>
        /// <param name="ProductCode">The product code in the OpenIncident</param>
        /// <param name="DateOpened">The date the OpenIncident was opened</param>
        /// <param name="CustomerName">The name of the customer whose is the OpenIncident</param>
        /// <param name="TechnicianName">The name of the technician managing the OpenIncident</param>
        /// <param name="Title">The title of the OpenIncident</param>
        /// <param name="Description">The description of the OpenIncident</param>
        public OpenIncident(string ProductCode, DateTime DateOpened, string CustomerName, string TechnicianName, 
            string Title, string Descrption)
        {
            if (string.IsNullOrEmpty(CustomerName) || string.IsNullOrEmpty(Title) 
                || string.IsNullOrEmpty(ProductCode) || string.IsNullOrEmpty(Description))
            {
                throw new ArgumentException("title " + "customer name " + "technician name " + "date opened " + "product code " + "description",
                      "Product Code, Customer Name, Technician Name, Title, and Description cannot be null or empty");
            }
            if (DateOpened == null)
            {
                throw new ArgumentException("date opened", "Date Opened cannot be null");
            }

            this.ProductCode = ProductCode;
            this.DateOpened = DateOpened;
            this.CustomerName = CustomerName;
            this.TechnicianName = TechnicianName;
            this.Title = Title;
            this.Description = Description;
        }
    }
}
