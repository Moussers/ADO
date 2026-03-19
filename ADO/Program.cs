using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
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
            cmd = "SELECT COUNT(*) FROM Movies";
            outputInfoScalar(command, cmd);
            connection = DisconnectDatabse(connection);
        }
        static SqlConnection DisconnectDatabse(SqlConnection connection) 
        {
            if(CheckConnectToDatabase(connection) == true)
            {
                connection.Close();
            }
            return connection;
        }
        static SqlConnection ConnectDatabase(string pathToDatabase) 
        {
            SqlConnection connection = new SqlConnection(pathToDatabase);    //подключение
            connection.Open();
            return connection;
        }
        static bool CheckConnectToDatabase(SqlConnection connection) 
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
        static void outputInfoNotScalar(SqlCommand command)
        { 
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
        }
        static void outputInfoScalar(SqlCommand command, string queryText) 
        {
            command.CommandText = "SELECT COUNT(*) FROM Movies";
            //Замена текста команды используя функцию CommandText
            Console.WriteLine($"Колличество записей:\t{command.ExecuteScalar()}");
            //ExecuteScalar - вынимает одно значение, это и есть скалярный запрос
        }
    }
}
