using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    class OpenIncident
    {
        public int ProductCode { get; }
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
        public OpenIncident(int ProductCode, string DateOpened, string CustomerName, string TechnicianName, string Title)
        {
            if (string.IsNullOrEmpty(DateOpened) || string.IsNullOrEmpty(CustomerName)
                || string.IsNullOrEmpty(TechnicianName) || string.IsNullOrEmpty(Title))
            {
                throw new ArgumentException("title " + "customer name" + "technician name" + "date opened", 
                      "Title, Date Opened, Customer Name, and Technician Name cannot be empty or null");
            }
            if (ProductCode < 0)
            {
                throw new ArgumentOutOfRangeException("product code", "Product Code must be greater than 0");
            }

            this.ProductCode = ProductCode;
            this.DateOpened = DateOpened;
            this.CustomerName = CustomerName;
            this.TechnicianName = TechnicianName;
            this.Title = Title;
        }
    }
}
