using System;
using System.Linq;
using System.Text;
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
        public void Select(string field, string tables, string condition = "") 
        {
            string cmd = $"SELECT {field} FROM {tables}";
            if (condition != "") cmd += $" WHERE {condition}";
            cmd += ";";
            Select(cmd);
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
        public int GetNextPrimaryKey(string table) 
        {
            return GetMaxPrimaryKey(table) + 1;
        }
        public string GetPrimaryKeyName(string tableName) 
        {
            connection.Open();
            //string cmd = "SELECT table_name, constraint_type, constraint_name FROM information_schema.table_constraints WHERE table_name = " + tableName;
            string cmd = "SELECT K.COLUMN_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS T" +
                " JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS K" +
                " ON K.CONSTRAINT_NAME=T.CONSTRAINT_NAME WHERE T.CONSTRAINT_TYPE = 'PRIMARY KEY' AND T.TABLE_NAME = '"+tableName+"'";
            SqlCommand command = new SqlCommand(cmd, connection);
            string ret = command.ExecuteScalar().ToString();
            return ret;
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
    }
}
