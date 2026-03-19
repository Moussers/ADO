using System.Data;
using System.Data.SqlClient;

namespace DataBase.CheckConnectLink
{
    internal class CheckConnectToDB
    {
        public static bool CheckConnectToDatabase(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Closed)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}