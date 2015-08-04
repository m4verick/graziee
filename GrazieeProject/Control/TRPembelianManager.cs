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
    class TRPembelianManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public TRPembelianManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        #region TRPembelian
        public bool AddTRPembelian(TransaksiPembelian trPembelian)
        {
            bool result = false;

            query = "INSERT INTO transaksi_pembelian VALUES('" + trPembelian.Id_transaksi_pembelian + "','" + trPembelian.Tgl_tr_pembelian + "')";

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

        public bool DeleteTRPembelian(TransaksiPembelian trPembelian)
        {
            bool result = false;

            query = "DELETE FROM transaksi_pembelian WHERE id_transaksi_pembelian = '" + trPembelian.Id_transaksi_pembelian + "'";

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
        #endregion

        #region DetailTRPembelian
        public bool AddDetailTRPembelian(DetailTRPembelian detTrPembelian)
        {
            bool result = false;

            query = "INSERT INTO detail_tr_pembelian VALUES('" + detTrPembelian.Id_detail_tr_pembelian + "','" + detTrPembelian.Id_transaksi_pembelian_fk + "','" + detTrPembelian.Id_barang_fk + "')";

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

        public bool DeleteDetailTRPembelian(DetailTRPembelian detTrPembelian)
        {
            bool result = false;

            query = "DELETE FROM detail_tr_pembelian WHERE id_detail_tr_pembelian = '" + detTrPembelian.Id_detail_tr_pembelian + "'";

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

        public DataSet GetDataDetailTRPembelian()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM detail_tr_pembelian";

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
        #endregion
    }
}
