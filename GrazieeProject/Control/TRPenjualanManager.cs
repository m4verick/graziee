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
    class TRPenjualanManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public TRPenjualanManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        #region TRPenjualan
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
    }
}
