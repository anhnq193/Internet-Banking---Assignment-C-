using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking_AsmCShape
{
    class DBConnection
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        public DBConnection()
        {
            OpenConnection();
        }

        private static void OpenConnection()
        {
            server = "localhost";
            database = "internet_banking";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";CharSet=utf8;";
            connection = new MySqlConnection(connectionString);
        }

        public static MySqlConnection GetConnection()
        {
            try
            {
                if (IsConnected() == false)
                    OpenConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            return connection;
        }

        public static bool IsConnected()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Error");
                        break;

                    case 1045:
                        Console.WriteLine("Error");
                        break;
                }
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                if (IsConnected() == true)
                    connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error" + ex.Message);
                return false;
            }
        }
    }
}
