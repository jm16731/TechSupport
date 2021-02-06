using System.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// The class that manages the connection to a TechSupport Database on SQL Server
    /// </summary>
    public class IncidentSQLServerConnection
    {
        /// <summary>
        /// Returns the connection to SQL Server's TechSupport database
        /// </summary>
        /// <returns>The SqlConnection to TechSupport DB</returns>
        public static SqlConnection GetConnection()
        {
            //string connectionString =
            //     "Data Source=localhost;Initial Catalog=TechSupport;" +
            //     "Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);
            return new SqlConnection("Data Source=localhost;Initial Catalog=TechSupport;Integrated Security=True");
        }
    }
}
