using DataBase.CheckConnectLink;
using System.Data.SqlClient;

namespace DataBase.Disconnect
{
    internal class DisconnectDB
    {
        public static SqlConnection DisconnectDatabase(SqlConnection connection)
        {
            if (CheckConnectToDB.CheckConnectToDatabase(connection) == true)
            {
                connection.Close();
            }
            return connection;
        }
    }
}