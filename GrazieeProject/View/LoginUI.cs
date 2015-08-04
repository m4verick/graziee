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
    public partial class LoginUI : Form
    {
        UserSistem s_userSistem;
        UserSistemManager s_userSistemManager;

        public LoginUI()
        {
            InitializeComponent();
            s_userSistemManager = new UserSistemManager();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.TextLength > 0 && txt_Password.TextLength > 0)
            {
                s_userSistem = new UserSistem(txt_Username.Text.ToString(), txt_Password.Text.ToString());
                if (s_userSistemManager.ValidateLogin(s_userSistem))
                {
                    MessageBox.Show("Login berhasil");
                    this.Hide();
                    MainUI s_mainUI = new MainUI();
                    s_mainUI.Show();
                }
                else
                {
                    MessageBox.Show("Login gagal");
                }
            }
            else
            {
                MessageBox.Show("Mohon mengisi Nama Pengguna atau Kata Sandi atau keduanya");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
