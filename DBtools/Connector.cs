using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DBtools
{
    public class Connector
    {
        string connection_string;
        SqlConnection connection;
        public Connector(string connection_string)
        {
            Console.WriteLine(connection_string);
            this.connection_string = connection_string;
            connection = new SqlConnection(connection_string);
        }
        public DataTable Select(string cmd)
        {
            DataTable table = new DataTable();
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            SqlDataReader reader = command.ExecuteReader();
            //выполнение команды
            //ExecuteReader - вынимает таблицу, то есть набор значений
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write(reader.GetName(i) + "\t");
                table.Columns.Add(reader.GetName(i));
            }
            Console.WriteLine();
            while (reader.Read())       //Переход на следующую строку, пока строки не кончатся (NULL)
            {
                DataRow row = table.NewRow();
                //Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}\t{reader[3]}");
                for (int i = 0; i < reader.FieldCount; ++i)     //Проход по столбцам и вывод информации с каждого из столбцов
                {
                    row[i] = reader[i];
                    Console.Write($"{reader[i]}\t");
                }
                Console.WriteLine();
                table.Rows.Add(row);
            }
            reader.Close();
            connection.Close();
            return table;
        }
        public DataTable Select(string field, string tables, string condition = "")
        {
            string cmd = $"SELECT {field} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            return Select(cmd);
        }
        public Dictionary<string, int> GetDictionary(string table, string condition = "")
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            string cmd =
            $"SELECT {table.Substring(0, table.Length - 1)}_name, {table.Substring(0, table.Length - 1)}_id FROM {table}";
            if (condition != "") cmd += $" WHERE {condition}";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dictionary.Add(reader[0].ToString(), Convert.ToInt32(reader[1]));
            }
            reader.Close();
            connection.Close();
            return dictionary;
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
        public void Insert(string cmd)
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
        public int GetNextPrimaryKey(string table)
        {
            return GetMaxPrimaryKey(table) + 1;
        }
        public string GetPrimaryKeyColumnName(string table)
        {
            //string raw = @"RAW string";     //RAW-строка игнорирует переносы
            string cmd = $@"SELECT INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME
FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
WHERE TABLE_NAME = N'{table}' 
AND CONSTRAINT_NAME LIKE N'PK_%';";
            return (string)Scalar(cmd);
        }
        public int GetMaxPrimaryKey(string table)
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
        public void Insert(string table, string[] fields, string[] values)
        {
            string condition = "";
            string[] s_fileds = fields;
            string[] s_values = values;
            string parsed_values = $"{s_values[0]},";
            for (int i = 1; i < s_fileds.Length; i++)
            {
                condition += $" {s_fileds[i]}={s_values[i]}";
                    parsed_values += s_values[i];
                if (i != s_fileds.Length - 1)
                {
                    condition += "AND";
                    parsed_values += ",";
                }
            }
            string new_field = "";
            for (int i = 0; i < s_fileds.Length; ++i)
            {
                new_field += s_fileds[i].ToString();
                if (i != s_fileds.Length - 1)
                {
                    new_field += ",";
                }
            }
            string cmd = $"IF NOT EXISTS(SELECT {GetPrimaryKeyColumnName(table)} FROM {table} WHERE {condition})";
            cmd += $"INSERT {table}({new_field}) VALUES ({parsed_values})";
            Insert(cmd);
        }
    }
}
