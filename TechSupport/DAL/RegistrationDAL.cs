using System;
using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class manages SQL queries to the Registrations table of the TechSupport db
    /// </summary>
    class RegistrationDAL
    {

        /// <summary>
        /// Verifies if the Customer is registered with this Product
        /// </summary>
        /// <param name="customerID">ID of the customer</param>
        /// <param name="productCode">Code of the product</param>
        /// <returns></returns>
        public static bool IsCustomerRegisteredToProduct(int customerID, string productCode)
        {
            SqlParameter registered;
            using (SqlConnection connection = GetSQLConnection.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("isCustomerRegisteredToProduct", connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@ProductCode", productCode);

                    registered = new SqlParameter("@registered", System.Data.SqlDbType.Bit)
                    {
                        Direction = System.Data.ParameterDirection.Output
                    };
                    command.Parameters.Add(registered);

                    command.ExecuteNonQuery();
                }
            }
            if (Convert.ToBoolean(registered.Value) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
