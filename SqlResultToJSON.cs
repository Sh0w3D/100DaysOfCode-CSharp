using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace TestSerialization
{
    class MainClass
    {
        static MySqlConnection connection;

        public static void Connect(string username, string password)
        {
            connection = new MySqlConnection();
            
            try
            {
                connection.ConnectionString = $"server=<server>," +
                    $"<port>; Database=<db name>; User Id ={username}; " +
                    $"Password={password}";
                connection.Open();
                Console.WriteLine("Connected succesfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"There was an error! Check: {e}");
            }
        }
        public static string getData()
        {
            MySqlDataReader reader;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String query = "SELECT * FROM <table name>";
            String jsonString = "";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();
            
            List<object> objects = new List<object>();

            while(reader.Read())
            {
                IDictionary<string, object> record = new Dictionary<string,
                    object>();

                for(int i = 0; i < reader.FieldCount; i++)
                {
                    record.Add(reader.GetName(i), reader[i]);
                }
                objects.Add(record);
            }
            jsonString = JsonConvert.SerializeObject(objects);

            reader.Close();
            command.Dispose();

            return jsonString;
        }

        public static void Main(string[] args)
        {
            Connect("<username>", "<password>");
            Console.WriteLine(getData());
        }
    }
}
