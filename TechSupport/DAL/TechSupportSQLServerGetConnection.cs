using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// The class that manages the connection to a TechSupport Database on SQL Server
    /// </summary>
    public class TechSupportSQLServerGetConnection
    {
        /// <summary>
        /// Returns the connection to SQL Server's TechSupport database
        /// </summary>
        /// <returns>The SqlConnection to TechSupport DB</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost;Initial Catalog=TechSupport;Integrated Security=True");
        }
    }
}
