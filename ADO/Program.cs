using System;
using System.Data.SqlClient;
using System.Web;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //строка подключения
            Connector connector = new Connector(connection_string);
            connector.Insert("ALTER SEQUENCE dirSeq RESTART WITH "+ connector.Scalar("SELECT COUNT(*)+1 FROM Directors") + ";");
            //SELECT COUNT(*) - возвращает значение последнего id из таблицы.
            string first_name = "Guy";
            string last_name = "Richie";
            connector.Insert($"IF NOT EXISTS(SELECT first_name, last_name FROM Directors WHERE first_name = N'{first_name}' AND last_name = N'{last_name}')" +
                $"BEGIN " +
                $"INSERT INTO Directors (director_id, first_name, last_name) VALUES (NEXT VALUE FOR dirSeq, N'{first_name}', N'{last_name}'); " +
                $"END");
            //connector.Insert($"INSERT INTO Directors (director_id, first_name, last_name) VALUES (NEXT VALUE FOR dirSeq, N'{first_name}', N'{last_name}');");
            //connector.Insert("DELETE FROM Directors WHERE director_id = 14");
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
            Console.WriteLine($"Тест назввания ключа: {connector.GetPrimaryKeyName("Movies")}");
        }
    }
}
