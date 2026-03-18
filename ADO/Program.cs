using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Movies_PV_521;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //строка подключения
            Console.WriteLine(connection_string);
            SqlConnection connection = new SqlConnection(connection_string);    //подключение
            connection.Open();
            string cmd = "SELECT movie_id, title, release_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
            SqlCommand command = new SqlCommand(cmd, connection);
            //прописывание и создание команды
            SqlDataReader reader = command.ExecuteReader();
            //выполнение команды
            //ExecuteReader - вынимает таблицу, то есть набор значений
            for (int i = 0; i < reader.FieldCount; i++) 
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine();
            while (reader.Read())       //Переход на следующую строку, пока строки не кончатся (NULL)
            {
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}\t{reader[3]}");
                for (int i = 0; i < reader.FieldCount; ++i)     //Проход по столбцам и вывод информации с каждого из столбцов
                {
                    Console.Write($"{reader[i]}\t");        
                }
                Console.WriteLine();
            }
            reader.Close();
            command.CommandText = "SELECT COUNT(*) FROM Movies";
            //Замена текста команды используя функцию CommandText
            Console.WriteLine($"Колличество записей:\t{command.ExecuteScalar()}");
            //ExecuteScalar - вынимает одно значение, это и есть скалярный запрос
            connection.Close();
        }
    }
}
