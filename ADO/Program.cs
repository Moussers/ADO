using ADO_Connector;
using System;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //строка подключения
            ADO_Connector.ADO_Connector connector = new ADO_Connector.ADO_Connector(connection_string);
            Console.WriteLine("_________________________________________________");
            Console.WriteLine(ADO_Connector.ADO_Connector.GetPrimaryKeyColumnName("Directors"));
            Console.WriteLine(ADO_Connector.ADO_Connector.GetPrimaryKeyColumnName("Movies"));
            //connector.Insert($@"INSERT Directors (director_id, first_name,last_name) VALUES ({connector.GetNextPrimaryKey("Directors")}, N'Guy', N'Richie');");
            ADO_Connector.ADO_Connector.Insert(
                "Directors", 
                "director_id,first_name,last_name",
                $"{ADO_Connector.ADO_Connector.GetNextPrimaryKey("Directors")},John,Singleton"
                );
            Console.WriteLine($"PK Max:\t{ADO_Connector.ADO_Connector.GetMaxPrimaryKey("Directors")}");
            //string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            //connector.Select(cmd);
            ADO_Connector.ADO_Connector.Select("*", "Directors");
            Console.WriteLine($"Количество записей: {ADO_Connector.ADO_Connector.Scalar("SELECT COUNT(*) FROM Movies")}");
            ADO_Connector.ADO_Connector.Select("SELECT * FROM Directors");
            ADO_Connector.ADO_Connector.Select(
                "title,release_date,first_name,last_name",
                "Movies,Directors",
                "director=director_id"
                );
            Console.WriteLine($"Количество записей: {ADO_Connector.ADO_Connector.Scalar("SELECT COUNT(*) FROM Directors")}");
        }
    }
}
