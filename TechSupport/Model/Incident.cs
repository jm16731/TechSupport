using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models an Incident to report to Tech Support. Wraps together various data
    /// </summary>
    public class Incident
    {
        public string Title { get; }
        public string Description { get; }
        public int CustomerID { get; }

        /// <summary>
        /// Creates an Incident according to the given parameters
        /// </summary>
        /// <param name="title">Meaningful name for the Incident</param>
        /// <param name="description">Explanation of the Incident</param>
        /// <param name="customerID">ID the of the customer whose is the Incident</param>
        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("title " + "description", "Title and Description cannot be null or empty");
            }
            if (customerID < 0)
            {
                throw new ArgumentOutOfRangeException("customerID", "customerID must be greater than 0");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
    }
}
