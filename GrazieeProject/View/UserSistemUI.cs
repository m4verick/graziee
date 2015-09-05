using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GrazieeProject.Model;
using GrazieeProject.Control;

namespace GrazieeProject.View
{
    public partial class UserSistemUI : Form
    {
        UserSistem s_userSistem;
        UserSistemManager s_userSistemManager;

        private BindingSource s_BindingUserSistem = new BindingSource();

        public UserSistemUI()
        {
            InitializeComponent();
            s_userSistemManager = new UserSistemManager();
            txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring((s_userSistemManager.GetMaxIDUserSistem().IndexOf("-")) + 1));
            DisplayUserSistem();
        }

        private void btn_AddUserSistem_Click(object sender, EventArgs e)
        {
            if (txt_NamaPengguna.TextLength > 0 && txt_KataSandi.TextLength > 0 && txt_UlangiKataSandi.TextLength > 0 && cmb_Role.SelectedIndex != -1)
            {
                s_userSistem = new UserSistem(Utils.ConcatMaxID(txt_IdPenggunaSistem.Text.ToString(), txt_IdPenggunaSistemNum.Text.ToString()), txt_NamaPengguna.Text.ToString(), Utils.PassEncrypt(txt_KataSandi.Text.ToString(), true), cmb_Role.SelectedItem.ToString());
                if (s_userSistemManager.AddUserSistem(s_userSistem))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring(s_userSistemManager.GetMaxIDUserSistem().IndexOf("-") + 1));
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambah");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }

        private void btn_EditUserSistem_Click(object sender, EventArgs e)
        {
            if (txt_NamaPengguna.TextLength > 0 && txt_KataSandi.TextLength > 0 && txt_UlangiKataSandi.TextLength > 0 && cmb_Role.SelectedIndex != -1)
            {
                s_userSistem = new UserSistem(Utils.ConcatMaxID(txt_IdPenggunaSistem.Text.ToString(), txt_IdPenggunaSistemNum.Text.ToString()), txt_NamaPengguna.Text.ToString(), Utils.PassEncrypt(txt_KataSandi.Text.ToString(), true), cmb_Role.SelectedItem.ToString());
                if (s_userSistemManager.UpdateUserSistem(s_userSistem))
                {
                    MessageBox.Show("Data berhasil diubah");
                    txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring((s_userSistemManager.GetMaxIDUserSistem().IndexOf("-")) + 1));
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }

        private void btn_DeleteUserSistem_Click(object sender, EventArgs e)
        {
            if (txt_NamaPengguna.TextLength > 0 && txt_KataSandi.TextLength > 0 && txt_UlangiKataSandi.TextLength > 0 && cmb_Role.SelectedIndex != -1)
            {
                s_userSistem = new UserSistem(Utils.ConcatMaxID(txt_IdPenggunaSistem.Text.ToString(), txt_IdPenggunaSistemNum.Text.ToString()), txt_NamaPengguna.Text.ToString(), Utils.PassEncrypt(txt_KataSandi.Text.ToString(), true), cmb_Role.SelectedItem.ToString());
                if (s_userSistemManager.DeleteUserSistem(s_userSistem))
                {
                    MessageBox.Show("Data berhasil dihapus");
                    txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring((s_userSistemManager.GetMaxIDUserSistem().IndexOf("-")) + 1));
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }

        private void btn_DeletePermanenUserSistem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan menghapus semua data secara permanen. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                s_userSistem = new UserSistem();
                s_userSistem.Id_user_sistem = Utils.ConcatMaxID(txt_IdPenggunaSistem.Text.ToString(), txt_IdPenggunaSistemNum.Text.ToString());

                if (s_userSistemManager.DeleteUserSistemPermanen(s_userSistem))
                {
                    MessageBox.Show("Data berhasil dihapus permanen");
                    txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring((s_userSistemManager.GetMaxIDUserSistem().IndexOf("-")) + 1));
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus permanen");
                }
            }
            else
            {
                return;
            }
        }

        private void btn_RestoreUserSistem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan memulihkan semua data yang pernah dihapus. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (s_userSistemManager.RestoreData())
                {
                    MessageBox.Show("Data berhasil dipulihkan");
                    txt_IdPenggunaSistemNum.Text = Utils.DisplayMaxID(s_userSistemManager.GetMaxIDUserSistem().Substring((s_userSistemManager.GetMaxIDUserSistem().IndexOf("-")) + 1));
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Data gagal dipulihkan");
                }
            }
            else
            {
                return;
            }
        }

        private void DisplayUserSistem()
        {
            s_BindingUserSistem.DataSource = s_userSistemManager.GetDataUserSistem().Tables[0];
            s_BindingUserSistem.Filter = string.Empty;
            dg_DisplayUserSistem.DataSource = s_BindingUserSistem;
        }

        private void DisplayUserSistemSearch(string name)
        {
            s_BindingUserSistem.DataSource = s_userSistemManager.GetDataUserSistemByName(name).Tables[0];
            s_BindingUserSistem.Filter = string.Empty;
            dg_DisplayUserSistem.DataSource = s_BindingUserSistem;
        }

        private void dg_DisplayUserSistem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdPenggunaSistemNum.Text = dg_DisplayUserSistem[0, currentRow].Value.ToString().Substring((dg_DisplayUserSistem[0, currentRow].Value.ToString().IndexOf("-")) + 1);
                    txt_NamaPengguna.Text = dg_DisplayUserSistem[1, currentRow].Value.ToString();
                    txt_KataSandi.Text = Utils.PassDecrypt(dg_DisplayUserSistem[2, currentRow].Value.ToString(), true);
                    cmb_Role.Text = dg_DisplayUserSistem[3, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data user sistem", "Error");
            }
        }

        private void ClearField()
        {
            txt_NamaPengguna.Text = String.Empty;
            txt_KataSandi.Text = String.Empty;
            txt_UlangiKataSandi.Text = String.Empty;
            cmb_Role.SelectedIndex = -1;
            DisplayUserSistem();
        }

        private void txt_SearchUserSistem_TextChanged(object sender, EventArgs e)
        {
            DisplayUserSistemSearch(txt_SearchUserSistem.Text.ToString());
        }
    }
}
