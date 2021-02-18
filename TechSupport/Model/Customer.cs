using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models a Customer of TechSupport
    /// </summary>
    public class Customer
    {
        public int ID { get; }
        public string Name { get; }
        public string Address { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public string Phone { get; }
        public string Email { get; }

        /// <summary>
        /// Creates a Customer according to parameters, with Phone and Email being null
        /// </summary>
        /// <param name="ID">ID of the customer</param>
        /// <param name="Name">Name of the customer</param>
        /// <param name="Address">Address of the customer</param>
        /// <param name="City">City of the customer</param>
        /// <param name="State">State of the customer</param>
        /// <param name="ZipCode">Zip Code of the customer</param>
        public Customer (int ID, string Name, string Address, string City, string State, string ZipCode) : 
            this(ID, Name, Address, City, State, ZipCode, null, null)
        {
            
        }

        /// <summary>
        /// Creates a Customer according to parameters
        /// </summary>
        /// <param name="ID">ID of the customer</param>
        /// <param name="Name">Name of the customer</param>
        /// <param name="Address">Address of the customer</param>
        /// <param name="City">City of the customer</param>
        /// <param name="State">State of the customer</param>
        /// <param name="ZipCode">Zip Code of the customer</param>
        /// <param name="Phone">Phone Number of the customer</param>
        /// <param name="Email">Email of the customer</param>
        public Customer(int ID, string Name, string Address, string City, string State,
               string ZipCode, string Phone, string Email)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(City)
                || string.IsNullOrEmpty(State) || string.IsNullOrEmpty(ZipCode))
            {
                throw new ArgumentException("name " + "address " + "city " + "state " + "zip code",
                      "Name, Address, City, State, and Zip Code cannot be null or empty");
            }
            if (ID < 1000 || ID > 9999)
            {
                throw new ArgumentException("id", "id must be between 1000 and 9999, inclusive");
            }

            this.ID = ID;
            this.Name = Name;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.Phone = Phone;
            this.Email = Email;
        }

    }
}
