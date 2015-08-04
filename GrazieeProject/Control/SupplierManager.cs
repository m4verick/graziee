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
    class SupplierManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
       // private DataTable dataTable;
        private string query;

        public SupplierManager()
        {
            connect = new MySqlConnection();
            connect.ConnectionString = ConnectStrings.getConn();
            query = string.Empty;
        }

        public bool AddSupplier(Supplier supp)
        {
            bool result = false;

            query = "INSERT INTO supplier VALUES('" + supp.Id_supplier + "','" + supp.Nama_supplier + "','" + supp.Alamat_supplier + "','" + supp.No_telp_supplier + "')";

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

        public bool UpdateSupplier(Supplier supp)
        {
            bool result = false;

            query = "UPDATE supplier SET nama_supplier = '" + supp.Nama_supplier + "', alamat_supplier = '" + supp.Alamat_supplier + "', no_telp_supplier = '" + supp.No_telp_supplier + "' WHERE id_supplier = '" + supp.Id_supplier + "'";

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

        public bool DeleteSupplier(Supplier supp)
        {
            bool result = false;

            query = "UPDATE supplier SET status_deleted = 1 WHERE id_supplier = '" + supp.Id_supplier + "'";
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

        public bool DeleteSupplierPermanen(Supplier supp)
        {
            bool result = false;

            query = "DELETE FROM supplier WHERE id_supplier = '" + supp.Id_supplier + "'";

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

            query = "UPDATE supplier SET status_deleted = 1 WHERE status_deleted = 0";

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

        public DataSet GetDataSupplier()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM supplier";

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
