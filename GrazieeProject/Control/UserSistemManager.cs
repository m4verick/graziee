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
    class UserSistemManager
    {
        private MySqlConnection connect;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapt;
        private MySqlDataReader reader;

        private DataSet dataSet;
        // private DataTable dataTable;
        private string query;

        public UserSistemManager()
        {
            connect = ConnectStrings.newCONN;
            query = string.Empty;
        }

        public bool ValidateLogin(UserSistem u_ser)
        {
            bool result = false;

            query = "SELECT nama_user, pass_user FROM user_sistem WHERE nama_user = '" + u_ser.Nama_user + "' and pass_user = '" + u_ser.Password_user + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                reader = cmd.ExecuteReader();
                if (reader.HasRows == true)
                {
                    result = true;
                }
                else if (reader.HasRows == false)
                {
                    result = false;
                }
                reader.Close();
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

        public bool AddUserSistem(UserSistem u_ser)
        {
            bool result = false;

            query = "INSERT INTO user_sistem VALUES('" + u_ser.Id_user_sistem + "','" + u_ser.Nama_user + "','" + u_ser.Password_user + "','" + u_ser.Role_user + "', 0)";

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

        public bool UpdateUserSistem(UserSistem u_ser)
        {
            bool result = false;

            query = "UPDATE user_sistem SET nama_user = '" + u_ser.Nama_user + "', pass_user = '" + u_ser.Password_user + "', role_user = '" + u_ser.Role_user + "' WHERE id_user_sistem = '" + u_ser.Id_user_sistem + "'";

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

        public bool DeleteUserSistem(UserSistem u_ser)
        {
            bool result = false;

            query = "UPDATE user_sistem SET status_deleted = 1 WHERE id_user_sistem = '" + u_ser.Id_user_sistem + "'";

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

        public bool DeleteUserSistemPermanen(UserSistem u_ser)
        {
            bool result = false;

            query = "DELETE FROM user_sistem WHERE id_user_sistem = '" + u_ser.Id_user_sistem + "'";

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

            query = "UPDATE user_sistem SET status_deleted = 1 WHERE status_deleted = 0";

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

        public DataSet GetDataUserSistem()
        {
            dataSet = new DataSet();
            query = string.Empty;
            query = "SELECT * FROM user_sistem";

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

        public string GetRoleUserSistem(string namaUser, string passUser)
        {
            string result = String.Empty;

            query = string.Empty;
            query = "SELECT role_user FROM user_sistem WHERE nama_user = '" + namaUser + "' AND pass_user = '" + passUser + "'";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetString(0);
                }
                else
                {
                    result = String.Empty;
                }
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                result = String.Empty;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                result = String.Empty;
            }
            finally
            {
                connect.Close();
            }
            return result;
        }

        public string GetMaxIDUserSistem()
        {
            string result = String.Empty;

            query = string.Empty;
            query = "SELECT MAX(id_user_sistem) FROM user_sistem";

            try
            {
                connect.Open();
                cmd = new MySqlCommand(query, connect);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    result = reader.GetString(0);
                }
                else
                {
                    result = String.Empty;
                }
            }
            catch (MySqlException ex)
            {
                ex.Message.ToString();
                result = Utils.DEFAULT_ID_USER_SISTEM;
            }
            catch (Exception exec)
            {
                exec.Message.ToString();
                result = Utils.DEFAULT_ID_USER_SISTEM;
            }
            finally
            {
                connect.Close();
            }
            return result;
        }
    }
}
