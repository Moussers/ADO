using System;
using System.Data.SqlClient;

namespace OutputInfo.Scalar
{
    internal class OutputScalar
    {

        public static void outputInfoScalar(SqlCommand command, string queryText)
        {
            command.CommandText = "SELECT COUNT(*) FROM " + queryText;
            //Замена текста команды используя функцию CommandText
            Console.WriteLine($"Колличество записей:\t{command.ExecuteScalar()}");
            //ExecuteScalar - вынимает одно значение, это и есть скалярный запрос
        }
    }
}