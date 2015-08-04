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
    class PelangganManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public PelangganManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        public bool AddPelanggan(Pelanggan plg)
        {
            bool result = false;

            query = "INSERT INTO pelanggan VALUES('" + plg.Id_pelanggan + "','" + plg.Nama_pelanggan + "','" + plg.Alamat_pelanggan + "','" + plg.No_telp_pelanggan + "', 0)";

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

        /* //commented out
        public bool CheckIdPelanggan(string idPelanggan)
        {
            bool result = false;

            query = "SELECT id_pelanggan FROM pelanggan WHERE id_pelanggan = '" + idPelanggan + "' AND status_deleted = 0";

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
        */

        public bool UpdatePelanggan(Pelanggan plg)
        {
            bool result = false;

            query = "UPDATE pelanggan SET nama_pelanggan = '" + plg.Nama_pelanggan + "', alamat_pelanggan = '" + plg.Alamat_pelanggan + "', no_telp_pelanggan = '" + plg.No_telp_pelanggan + "' WHERE id_pelanggan = '" + plg.Id_pelanggan + "'";

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

        public bool DeletePelanggan(Pelanggan plg)
        {
            bool result = false;

            query = "UPDATE pelanggan SET status_deleted = 1 WHERE id_pelanggan = '" + plg.Id_pelanggan + "'";

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

        public bool DeletePelangganPermanen(Pelanggan plg)
        {
            bool result = false;

            query = "DELETE FROM pelanggan WHERE id_pelanggan = '" + plg.Id_pelanggan + "'";

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

            query = "UPDATE pelanggan SET status_deleted = 1 WHERE status_deleted = 0";

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

        public DataSet GetDataPelanggan()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM pelanggan";

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
