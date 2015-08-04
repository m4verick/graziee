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
    class WarnaMerekModelUkuranManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public WarnaMerekModelUkuranManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        #region WarnaBarang
        public bool AddWarna(WarnaBarang warna)
        {
            bool result = false;

            query = "INSERT INTO warna_barang VALUES('" + warna.Id_warna_barang + "','" + warna.Nama_warna + "')";

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

        public bool UpdateWarna(WarnaBarang warna)
        {
            bool result = false;

            query = "UPDATE warna_barang SET nama_warna = '" + warna.Nama_warna + "' WHERE id_warna_barang = '" + warna.Id_warna_barang + "'";

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

        public bool DeleteWarna(WarnaBarang warna)
        {
            bool result = false;

            query = "DELETE FROM warna_barang WHERE id_warna_barang = '" + warna.Id_warna_barang + "'";

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

        public DataSet GetDataWarna()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM warna_barang";

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

        public DataSet GetDataWarnaComboBox()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT id_warna, nama_warna FROM warna_barang";

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

        #region MerekBarang
        public bool AddMerek(MerekBarang merk)
        {
            bool result = false;

            query = "INSERT INTO merek_barang VALUES('" + merk.Id_merek_barang + "','" + merk.Nama_merek + "')";

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

        public bool UpdateMerek(MerekBarang merk)
        {
            bool result = false;

            query = "UPDATE merek_barang SET nama_merek = '" + merk.Nama_merek + "' WHERE id_warna_barang = '" + merk.Id_merek_barang + "'";

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

        public bool DeleteMerek(MerekBarang merk)
        {
            bool result = false;

            query = "DELETE FROM merek_barang WHERE id_merek_barang = '" + merk.Id_merek_barang + "'";

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

        public DataSet GetDataMerek()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM merek_barang";

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

        public DataSet GetDataMerekComboBox()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT id_merek_barang, nama_merek FROM merek_barang";

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

        #region ModelBarang
        public bool AddModel(ModelBarang model)
        {
            bool result = false;

            query = "INSERT INTO model_barang VALUES('" + model.Id_model_barang + "','" + model.Nama_model + "')";

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

        public bool UpdateModel(ModelBarang model)
        {
            bool result = false;

            query = "UPDATE model_barang SET nama_model = '" + model.Nama_model + "' WHERE id_model_barang = '" + model.Id_model_barang + "'";

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

        public bool DeleteModel(ModelBarang model)
        {
            bool result = false;

            query = "DELETE FROM model_barang WHERE id_model_barang = '" + model.Id_model_barang + "'";

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

        public DataSet GetDataModel()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM model_barang";

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

        public DataSet GetDataModelComboBox()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT id_model_barang, nama_model FROM model_barang";

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

        #region UkuranBarang
        public bool AddUkuran(UkuranBarang ukuran)
        {
            bool result = false;

            query = "INSERT INTO ukuran_barang VALUES('" + ukuran.Id_ukuran_barang + "','" + ukuran.Ukuran_barang + "')";

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

        public bool UpdateUkuran(UkuranBarang ukuran)
        {
            bool result = false;

            query = "UPDATE ukuran_barang SET ukuran = '" + ukuran.Ukuran_barang + "' WHERE id_ukuran_barang = '" + ukuran.Id_ukuran_barang + "'";

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

        public bool DeleteUkuran(UkuranBarang ukuran)
        {
            bool result = false;

            query = "DELETE FROM ukuran_barang WHERE id_ukuran_barang = '" + ukuran.Id_ukuran_barang + "'";

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

        public DataSet GetDataUkuran()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM ukuran_barang";

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

        public DataSet GetDataUkuranComboBox()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT id_ukuran_barang, ukuran FROM ukuran_barang";

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
