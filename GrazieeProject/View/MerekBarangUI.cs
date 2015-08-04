using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrazieeProject.Control;
using GrazieeProject.Model;

namespace GrazieeProject.View
{
    public partial class MerekBarangUI : Form
    {
        MerekBarang s_MerekBarang;
        WarnaMerekModelUkuranManager s_MerekBarangManager;

        public MerekBarangUI()
        {
            InitializeComponent();
            s_MerekBarangManager = new WarnaMerekModelUkuranManager();
        }

        private void btn_AddMerekBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaMerekBarang.TextLength > 0)
            {
                s_MerekBarang = new MerekBarang(txt_IdMerekBarang.Text.ToString(), txt_NamaMerekBarang.Text.ToString());
                if (s_MerekBarangManager.AddMerek(s_MerekBarang))
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
