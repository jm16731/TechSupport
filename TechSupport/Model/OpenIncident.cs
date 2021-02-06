using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    public class OpenIncident
    {
        public String ProductCode { get; }
        public string DateOpened { get; }
        public string CustomerName { get; }
        public string TechnicianName { get; }
        public string Title { get; }

        /// <summary>
        /// Creates an Incident according to the given parameters
        /// </summary>
        /// <param name="title">Meaningful name for the Incident</param>
        /// <param name="description">Explanation of the Incident</param>
        /// <param name="customerID">ID the of the customer whose is the Incident</param>
        public OpenIncident(string ProductCode, string DateOpened, string CustomerName, string TechnicianName, string Title)
        {
            if (string.IsNullOrEmpty(DateOpened) || string.IsNullOrEmpty(CustomerName)
                || string.IsNullOrEmpty(TechnicianName) || string.IsNullOrEmpty(Title) 
                || string.IsNullOrEmpty(ProductCode))
            {
                throw new ArgumentException("title " + "customer name" + "technician name" + "date opened" + "product code", 
                      "Product Code, Date Opened, Customer Name, Technician Name, and Title cannot be null or empty");
            }

            this.ProductCode = ProductCode;
            this.DateOpened = DateOpened;
            this.CustomerName = CustomerName;
            this.TechnicianName = TechnicianName;
            this.Title = Title;
        }
    }
}
