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
    class JenisSubJenisManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        //private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public JenisSubJenisManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        #region JenisBarang
        public bool AddJenisBarang(JenisBarang jnsBrg)
        {
            bool result = false;

            query = "INSERT INTO jenis_barang VALUES('" + jnsBrg.Id_jenis_barang + "','" + jnsBrg.Nama_jenis + "')";

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

        public bool UpdateJenisBarang(JenisBarang jnsBrg)
        {
            bool result = false;

            query = "UPDATE jenis_barang SET nama_jenis = '" + jnsBrg.Nama_jenis + "' WHERE id_jenis_barang = '" + jnsBrg.Id_jenis_barang + "'";

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

        public bool DeleteJenisBarang(JenisBarang jnsBrg)
        {
            bool result = false;

            query = "DELETE FROM jenis_barang WHERE id_jenis_barang = '" + jnsBrg.Id_jenis_barang + "'";

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

        public DataSet GetDataJenisBarang()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM jenis_barang";

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
        #endregion // JenisBarang

        #region SubJenisBarang
        public bool AddSubJenisBarang(SubJenisBarang subJnsBrg)
        {
            bool result = false;

            query = "INSERT INTO sub_jenis_barang VALUES('" + subJnsBrg.Id_sub_jenis_barang + "','" + subJnsBrg.Nama_sub_jenis + "')";

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

        public bool UpdateSubJenisBarang(SubJenisBarang subJnsBrg)
        {
            bool result = false;

            query = "UPDATE sub_jenis_barang SET nama_sub_jenis = '" + subJnsBrg.Nama_sub_jenis + "' WHERE id_sub_jenis_barang = '" + subJnsBrg.Id_sub_jenis_barang + "'";

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

        public bool DeleteSubJenisBarang(SubJenisBarang subJnsBrg)
        {
            bool result = false;

            query = "DELETE FROM sub_jenis_barang WHERE id_sub_jenis_barang = '" + subJnsBrg.Id_sub_jenis_barang + "'";

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

        public DataSet GetDataSubJenisBarang()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM sub_jenis_barang";

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
        #endregion //SubJenisBarang

        #region JenisSubJenis
        public bool AddJenisSubJenis(JenisSubJenis jnsSubJns)
        {
            bool result = false;

            //m4verick - data yang diambil dari UI adalah 'nama' bukan 'id', perlu inner query untuk mengambil id masing-masing
            query = "INSERT INTO jenis_sub_jenis VALUES('" + jnsSubJns.Id_jenis_sub_jenis + "',"+
                "(SELECT id_jenis_barang FROM jenis_barang WHERE nama_jenis = '" + jnsSubJns.Jenis_id_jenis_barang_fk + "'),"+
                "(SELECT id_sub_jenis_barang FROM sub_jenis_barang WHERE nama_sub_jenis = '" + jnsSubJns.Sub_jenis_id_sub_jenis_barang_fk + "'))";

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

        public bool UpdateJenisSubJenis(JenisSubJenis jnsSubJns)
        {
            bool result = false;

            //m4verick - data yang diambil dari UI adalah 'nama' bukan 'id', perlu inner query untuk mengambil id masing-masing
            query = "UPDATE jenis_sub_jenis SET id_jenis_barang_fk = (SELECT id_jenis_barang FROM jenis_barang WHERE nama_jenis = '" + jnsSubJns.Jenis_id_jenis_barang_fk + "'),"+
                "id_sub_jenis_barang_fk = (SELECT id_sub_jenis_barang FROM sub_jenis_barang WHERE nama_sub_jenis = '" + jnsSubJns.Sub_jenis_id_sub_jenis_barang_fk + "')"+
                "WHERE id_jenis_sub_jenis = '" + jnsSubJns.Id_jenis_sub_jenis + "'";

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

        public bool DeleteJenisSubJenis(JenisSubJenis jnsSubJns)
        {
            bool result = false;

            query = "DELETE FROM jenis_sub_jenis WHERE id_jenis_sub_jenis = '" + jnsSubJns.Id_jenis_sub_jenis + "'";

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

        public DataSet GetDataJenisSubJenis()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT jsj.id_jenis, jb.nama_jenis, sj.nama_sub_jenis FROM jenis_sub_jenis jsj JOIN jenis_barang jb ON jb.id_jenis_barang = jsj.id_jenis_barang JOIN sub_jenis_barang sj ON sj.id_sub_jenis_barang = jsj.id_sub_jenis_barang";

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

        public DataSet GetDataJenisSubJenisByName(string search)
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT jsj.id_jenis, jb.nama_jenis, sj.nama_sub_jenis FROM jenis_sub_jenis jsj JOIN jenis_barang jb ON jb.id_jenis_barang = jsj.id_jenis_barang JOIN sub_jenis_barang sj ON sj.id_sub_jenis_barang = jsj.id_sub_jenis_barang WHERE jb.nama_jenis LIKE '%" + search + "%'";

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
