using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace GrazieeProject.Control
{
    class ConnectStrings
    {
        private static string conn;

        public ConnectStrings()
        {
            try
            {
                conn = getConn();
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
            }
        }

        public static string getConn()
        {
            return "Server=localhost;Database=graziee;Uid=root;Pwd=";
        }

        public static string CONN
        {
            set { }
            get { return conn; }
        }

        public static MySqlConnection newCONN
        {
            set { }
            get { return new MySqlConnection(getConn()); }
        }
    }
}
