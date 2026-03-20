using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace ADO
{
    internal class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string) 
        {
            Console.WriteLine(connection_string);
            this.connection_string = connection_string;
            connection = new SqlConnection(connection_string);
        }
        public void Select(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
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
            connection.Close();
        }
        public object Scalar(string cmd)
        {
            object result = null;
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            result = command.ExecuteScalar();     //Выполнение скалярного запроса.
            connection.Close();
            return result;
        }
    }
}
