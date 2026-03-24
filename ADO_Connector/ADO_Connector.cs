using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Connector
{
    public class ADO_Connector
    {
        private readonly string connection_string;
        static SqlConnection connection;
        public ADO_Connector(string connection_string)
        {
            Console.WriteLine(connection_string);
            this.connection_string = connection_string;
            connection = new SqlConnection(connection_string);
        }
        public static void Select(string cmd)
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
        public static void Select(string field, string tables, string condition = "")
        {
            string cmd = $"SELECT {field} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Select(cmd);
        }
        public static object Scalar(string cmd)
        {
            object result = null;
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            result = command.ExecuteScalar();     //Выполнение скалярного запроса.
            connection.Close();
            return result;
        }
        public static void Insert(string cmd)
        {
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
                if (ex.GetType() == typeof(SqlException) && ex.Message.Contains("id"))
                {
                    Console.WriteLine("Good");
                }
            }
            connection.Close();
        }
        public static int GetNextPrimaryKey(string table)
        {
            return GetMaxPrimaryKey(table) + 1;
        }
        public static string GetPrimaryKeyColumnName(string table)
        {
            //string raw = @"RAW string";     //RAW-строка игнорирует переносы
            string cmd = $@"SELECT INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME
FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE TABLE_NAME = N'{table}' 
AND CONSTRAINT_NAME LIKE N'PK_%';";
            return (string)Scalar(cmd);
        }
        public static int GetMaxPrimaryKey(string table)
        {
            string cmd = $"SELECT * FROM {table}";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string pk_name = reader.GetName(0);
            reader.Close();
            connection.Close();
            return (int)Scalar($"SELECT MAX ({pk_name}) FROM {table}");
        }
        public static void Insert(string table, string fields, string values)
        {
            string condition = "";
            string[] s_fileds = fields.Split(',');
            string[] s_values = values.Split(',');
            string parsed_values = $"N'{s_values[0]}',";
            for (int i = 1; i < s_fileds.Length; i++)
            {
                condition += $" {s_fileds[i]}=N'{s_values[i]}' ";
                parsed_values += s_values[i][0] != 'N' && s_values[i][1] != '\'' ? $"N'{s_values[i]}'" : s_values[i];
                if (i != s_fileds.Length - 1)
                {
                    condition += "AND";
                    parsed_values += ",";
                }
            }
            string cmd = $"IF NOT EXISTS(SELECT {GetPrimaryKeyColumnName(table)} FROM {table} WHERE {condition})";
            cmd += $"INSERT {table}({fields}) VALUES ({parsed_values})";
            Insert(cmd);
        }
    }
}
