using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Models a Product of TechSupport
    /// </summary>
    public class Product
    {
        public string ProductCode { get; }
        public string Name { get; }
        public Decimal Version { get; }
        public DateTime ReleaseDate { get; }

        /// <summary>
        /// Creates a Product according to given parameters
        /// </summary>
        /// <param name="ProductCode">Code of the product</param>
        /// <param name="Name">Name of the product</param>
        /// <param name="Version">Version of the product</param>
        /// <param name="ReleaseDate">Release Date of the product</param>
        public Product(string ProductCode, string Name, Decimal Version, DateTime ReleaseDate)
        {
            if (string.IsNullOrEmpty(ProductCode) || string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("product code " + "name", "Product Code and Name cannot be null or empty");
            }
            if (ReleaseDate == null)
            {
                throw new ArgumentException("release date", "ReleaseDate cannot be null");
            }
            if (Version <= 0)
            {
                throw new ArgumentException("version", "Version cannot be zero or negative");
            }

            this.ProductCode = ProductCode;
            this.Name = Name;
            this.Version = Version;
            this.ReleaseDate = ReleaseDate;
        }
    }
}
