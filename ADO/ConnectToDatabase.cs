using System.Data.SqlClient;

namespace DataBase.Connect
{
    internal class ConnectToDatabase
    {
        public static SqlConnection ConnectDatabase(string pathToDatabase)
        {
            SqlConnection connection = new SqlConnection(pathToDatabase);   //подключение
            {    
                connection.Open();
                return connection;
            }
        }
    }
}