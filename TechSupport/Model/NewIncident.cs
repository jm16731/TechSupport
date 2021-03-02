using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models the creation of a New Incident
    /// </summary>
    public class NewIncident
    {
        public int CustomerID { get; }
        public string ProductCode { get; }
        public string Title { get; }
        public string Description { get; }

        public NewIncident(int customerID, string productCode, string title, string description)
        {
            if (string.IsNullOrEmpty(productCode) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("productCode " + "title " + "description", "Title, Description, " +
                    "and ProductCode cannot be null or empty");
            }
            if (customerID < 1)
            {
                throw new ArgumentException("customerID ", "IDs cannot be less than 1");
            }

            this.CustomerID = customerID;
            this.ProductCode = productCode;
            this.Title = title;
            this.Description = description;
        }
    }
}
