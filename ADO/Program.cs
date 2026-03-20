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
            connector.Insert("INSERT Directors (director_id, first_name,last_name) VALUES (12,N'Guy', N'Richie');");
            Console.WriteLine($"PK Max:\t{connector.GetMaxPrimaryKey("Directors")}");
            //string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            //connector.Select(cmd);
            connector.Select("*", "Directors");
            Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Movies")}");
            connector.Select("SELECT * FROM Directors");
            connector.Select(
                "title,release_date,first_name,last_name",
                "Movies,Directors",
                "director=director_id"
                );
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
