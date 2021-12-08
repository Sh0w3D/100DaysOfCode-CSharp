// Created by Sh0w3D | Kamil Oberaj on 08.12.2022
using System;
using MySql.Data.MySqlClient;

namespace NET
{
    class MainClass
    {

        static MySqlConnection connection;

        public static void Connect(string username, string password)
        {
            MySqlDataReader reader;
            MySqlCommand command;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            String query;
            connection = new MySqlConnection();

            try
            {
                connection.ConnectionString = $"server = <your host>; User id = " +
                    $"{username}; Persist Security Info = True; database = <your dbname> " +
                    $"Password = {password}";
                connection.Open();
                Console.WriteLine("Connected succesfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"There was an error! Check: {e}");
            }

            query = "SELECT * FROM users";
            command = new MySqlCommand(query, connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine(reader.GetValue(0) + " | "
                    + reader.GetValue(1) + " | " + reader.GetValue(2) + " | " +
                    reader.GetValue(3) + " | " + reader.GetValue(4) + " | " +
                    reader.GetValue(5) + " | " + reader.GetValue(6));
            }

            reader.Close();
            command.Dispose();

            query = "DELETE FROM users WHERE ID_US = 62";
            adapter.DeleteCommand = new MySqlCommand(query, connection);
            adapter.DeleteCommand.ExecuteNonQuery();

            command.Dispose();
            adapter.Dispose();
            connection.Close();
        }

        public static void Main(string[] args)
        {
            Connect("<your username>", "<your password>");
        }
    }
}
