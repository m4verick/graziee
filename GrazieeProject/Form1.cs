using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GrazieeProject
{
    public partial class Form1 : Form
    {

        private string conn = "Server=localhost;Database=graziee;Uid=root;Pwd=;";
        private MySqlConnection connection;
        private MySqlDataReader read;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from testing";
            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                connection.Open();
                read = command.ExecuteReader();
                if (read.HasRows == true)
                {
                    MessageBox.Show("ADA DATANYA dan koneksi berhasil", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("GA ADAAAAAAA", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                read.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
