using System;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //строка подключения
            Connector connector = new Connector(connection_string);
            string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            connector.Select(cmd);
            Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Movies")}");
            connector.Select("SELECT * FROM Directors");
            Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Directors")}");
            //string path = connection.Database;
            //Console.WriteLine(path.ToString());
            //string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            //SqlCommand command = new SqlCommand(cmd, connection);
            //прописывание и создание команды
            //outputInfoNotScalar(command);
            //cmd = "Movies";
            //outputInfoScalar(command, cmd);
        }
    }
}
