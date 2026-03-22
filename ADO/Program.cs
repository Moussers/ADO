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
            //connector.Insert("ALTER SEQUENCE dirSeq RESTART WITH "+ connector.Scalar("SELECT COUNT(*)+1 FROM Directors") + ";");
            //SELECT COUNT(*) - возвращает значение последнего id из таблицы.
            connector.Insert("INSERT INTO Directors (director_id, first_name, last_name) VALUES (NEXT VALUE FOR dirSeq, N'Robert', N'Zemeckis');");
            Console.WriteLine($"PK Max:\t{connector.GetMaxPrimaryKey("Directors")}");
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
