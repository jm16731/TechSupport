using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models a Technician of TechSupport
    /// </summary>
    public class Technician
    {
        public int ID { get; }
        public string Name { get; }
        public string Phone { get; }
        public string Email { get; }

        /// <summary>
        /// Creates a Technician according to parameters
        /// </summary>
        /// <param name="ID">ID of the technician</param>
        /// <param name="Name">Name of the technician</param>
        /// <param name="Phone">Phone Number of the technician</param>
        /// <param name="Email">Email of the technician</param>
        public Technician(int ID, string Name, string Phone, string Email)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Phone) || string.IsNullOrEmpty(Email))
            {
                throw new ArgumentException("name " + "phone " + "email ",
                      "Name, Phone, and Email cannot be null or empty");
            }
            if (ID < 1)
            {
                throw new ArgumentException("id", "id must be greater than zero");
            }

            this.ID = ID;
            this.Name = Name;
            this.Phone = Phone;
            this.Email = Email;
        }
    }
}
