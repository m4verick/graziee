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

        KurirManager s_KurirManager;

        public LoginUI()
        {
            InitializeComponent();
            s_userSistemManager = new UserSistemManager();
            s_KurirManager = new KurirManager();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.TextLength > 0 && txt_Password.TextLength > 0)
            {
                s_userSistem = new UserSistem(txt_Username.Text.ToString(), txt_Password.Text.ToString());
                if (s_userSistemManager.ValidateLogin(s_userSistem))
                {
                    generateBarcode();
                    MessageBox.Show("Login berhasil");
                    //string test = s_KurirManager.GetMaxIDKurir();
                    //int testing = int.Parse(test.Substring(4));
                    //MessageBox.Show(testing.ToString());
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

        private void generateBarcode()
        {
            // Create an linear barcode object (BarcodeLib.Barcode.Linear)
            BarcodeLib.Barcode.Linear barcode = new BarcodeLib.Barcode.Linear();

            // Set barcode type to Code 39
            barcode.Type = BarcodeLib.Barcode.BarcodeType.CODE39;

            // Set your encoded barcode value
            barcode.Data = "123456789";

            // Other barcode settings
            // Save barcode image into your system

            // Draw barcode image into a PNG file
            barcode.drawBarcode("D:\\barcode.png");
        }
    }
}
