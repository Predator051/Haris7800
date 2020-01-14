using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harris7800HMP.MySqlManager
{
    public class BDManager
    {
        public static SqlConnection CreateMySqlConnection()
        {
            string connectString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";
            return new SqlConnection(connectString);
        }

        public static DataSet SqlQuery(string strSqlQuery)
        {
            var connection = CreateMySqlConnection();
            connection.Open();

            SqlDataAdapter adp = new SqlDataAdapter(strSqlQuery, connection);
            DataSet returnData = new DataSet();
            adp.Fill(returnData);

            connection.Close();

            return returnData;
        }
    }
}
