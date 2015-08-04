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
    class BarangManager
    {
        
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public BarangManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        public bool AddBarang(Barang brg)
        {
            bool result = false;

            //m4verick - data yang diambil dari UI adalah 'nama' bukan 'id', perlu inner query untuk mengambil id masing-masing
            query = "INSERT INTO barang VALUES('" + brg.Id_barang + "','" + brg.Jenis_sub_jenis_id_jenis_sub_jenis_fk + "',"+
                "(SELECT id_ukuran_barang FROM ukuran_barang WHERE nama_ukuran = '" + brg.Ukuran_id_ukuran_barang_fk + "'),"+
                "(SELECT id_model_barang FROM model_barang WHERE nama_model = '" + brg.Model_id_model_barang_fk + "'),"+
                "(SELECT id_warna_barang FROM warna_barang WHERE nama_warna = '" + brg.Warna_id_warna_barang_fk + "'),"+
                "(SELECT id_merek_barang FROM merek_barang WHERE nama_merek = '" + brg.Merek_id_merek_barang_fk + "'),"+
                "(SELECT id_supplier FROM supplier WHERE nama_supplier = '" + brg.Supp_id_supplier_fk + "'), '" + brg.Gender + "', " + brg.Harga + ","+
                "'" + brg.Status_stok + "')";

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

        public bool UpdateBarang(Barang brg)
        {
            bool result = false;

            //m4verick - data yang diambil dari UI adalah 'nama' bukan 'id', perlu inner query untuk mengambil id masing-masing
            query = "UPDATE barang SET id_jenis_sub_jenis_fk = '" + brg.Jenis_sub_jenis_id_jenis_sub_jenis_fk + "',"+
                "id_ukuran_barang_fk = (SELECT id_ukuran_barang FROM ukuran_barang WHERE nama_ukuran = '" + brg.Ukuran_id_ukuran_barang_fk + "'),"+
                "id_model_barang_fk = (SELECT id_model_barang FROM model_barang WHERE nama_model = '" + brg.Model_id_model_barang_fk + "'),"+
                "id_warna_barang_fk = (SELECT id_warna_barang FROM warna_barang WHERE nama_warna = '" + brg.Warna_id_warna_barang_fk + "'),"+
                "id_merek_barang_fk = (SELECT id_merek_barang FROM merek_barang WHERE nama_merek = '" + brg.Merek_id_merek_barang_fk + "'),"+
                "id_supplier_fk = (SELECT id_supplier FROM supplier WHERE nama_supplier = '" + brg.Supp_id_supplier_fk + "') "+
                "WHERE id_barang = '" + brg.Id_barang + "'";

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

        public bool DeleteBarang(Barang brg)
        {
            bool result = false;

            query = "DELETE FROM barang WHERE id_barang = '" + brg.Id_barang + "'";

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

        public DataSet GetDataBarang()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM barang";

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
