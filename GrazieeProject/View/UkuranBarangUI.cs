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
    public partial class UkuranBarangUI : Form
    {
        UkuranBarang s_UkuranBarang;
        WarnaMerekModelUkuranManager s_UkuranBarangManager;

        public UkuranBarangUI()
        {
            InitializeComponent();
        }

        private void btn_AddUkuranBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaUkuran.TextLength > 0)
            {
                s_UkuranBarang = new UkuranBarang(txt_IdUkuran.Text.ToString(), txt_NamaUkuran.Text.ToString());
                if (s_UkuranBarangManager.AddUkuran(s_UkuranBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
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
    }
}
