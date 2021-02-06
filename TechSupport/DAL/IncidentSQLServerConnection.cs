using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    class IncidentSQLServerConnection
    {
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
