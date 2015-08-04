using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//m4verick - import SQL CLient and Data
using MySql.Data.MySqlClient;
using System.Data;
using GrazieeProject.Model;
using System.Windows.Forms;

namespace GrazieeProject.Control
{
    class KurirManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public KurirManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        public bool AddKurir(Kurir kurir)
        {
            bool result = false;

            query = "INSERT INTO kurir VALUES('" + kurir.Id_kurir + "','" + kurir.Nama_kurir + "','" + kurir.Alamat_kurir + "','" + kurir.No_telp_kurir + "')";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public bool UpdateKurir(Kurir kurir)
        {
            bool result = false;

            query = "UPDATE kurir SET nama_kurir = '" + kurir.Nama_kurir + "', alamat_kurir = '" + kurir.Alamat_kurir + "', no_telp_kurir = '" + kurir.No_telp_kurir + "' WHERE id_kurir = '" + kurir.Id_kurir + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public bool DeleteKurir(Kurir kurir)
        {
            bool result = false;

            query = "UPDATE kurir SET status_deleted = 1 WHERE id_pelanggan = '" + kurir.Id_kurir + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public bool DeleteKurirPermanen(Kurir kurir)
        {
            bool result = false;

            query = "DELETE FROM kurir WHERE id_kurir = '" + kurir.Id_kurir + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public bool RestoreData()
        {
            bool result = false;

            query = "UPDATE kurir SET status_deleted = 1 WHERE status_deleted = 0";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
                result = false;
            }
            finally
            {
                connect.Close();
            }

            return result;
        }

        public DataSet GetDataKurir()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM kurir";

            try
            {
                connect.Open();
                adapt = new MySqlDataAdapter(query, connect);
                adapt.Fill(dataSet);
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                return null;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                return null;
            }
            finally
            {
                connect.Close();
            }
            return dataSet;
        }
    }
}
