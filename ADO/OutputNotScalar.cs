using System;
using System.Data.SqlClient;

namespace OutputInfo.NotScalar
{
    internal class OutputNotScalar
    {

        public static void outputInfoNotScalar(SqlCommand command)
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
    }
}