using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adonet.Helper
{
    static class Sql
    {
        static string connetctionstring = "SERVER = DESKTOP-V540I6U \\ Database=Spotify1";
        static SqlConnection _connection;
        private static System.Data.SqlClient.SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(connetctionstring);
                }
                return _connection;
            }
        }
        public static int ExecCommand (string command)
        {
            int result = 0;
            Connection.Open();
            using (SqlCommand sqlCommand = new SqlCommand(command, connection))
            {
                result = sqlCommand.ExecuteNonQuery();
            }
            connection.Close();
            return result;

        }
        public static DataTable ExecQuery(string query) 
        { 
            DataTable dt = new DataTable();
            connection.Open();
            using (SqlDataAdapter sda = new SqlDataAdapter(query,connection))
            { 
                sda.Fill(dt);
            }
            connection.Close();
            return dt;
        }
    }
}
