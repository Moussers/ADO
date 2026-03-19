using System;
using DataBase.Connect;
using static OutputInfo.NotScalar.OutputNotScalar;
using static OutputInfo.Scalar.OutputScalar;
//using static - Используем чтобы не вызывать классы, а только их функции.
using DataBase.Disconnect;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program : ConnectToDatabase
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //строка подключения
            Console.WriteLine(connection_string);
            SqlConnection connection = ConnectDatabase(connection_string);
            string path = connection.Database;
            Console.WriteLine(path.ToString());
            string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            SqlCommand command = new SqlCommand(cmd, connection);
            //прописывание и создание команды
            outputInfoNotScalar(command);
            cmd = "Movies";
            outputInfoScalar(command, cmd);
            connection = DisconnectDB.DisconnectDatabase(connection);
        }
    }
}
