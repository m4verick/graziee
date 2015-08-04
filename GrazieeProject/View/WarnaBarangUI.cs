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
    public partial class WarnaBarangUI : Form
    {
        WarnaBarang s_WarnaBarang;
        WarnaMerekModelUkuranManager s_WarnaBarangManager;

        public WarnaBarangUI()
        {
            InitializeComponent();
            s_WarnaBarangManager = new WarnaMerekModelUkuranManager();
        }

        private void btn_TambahWarnaBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaWarna.TextLength > 0)
            {
                s_WarnaBarang = new WarnaBarang(txt_IdWarnaBarang.Text.ToString(), txt_NamaWarna.Text.ToString());
                if (s_WarnaBarangManager.AddWarna(s_WarnaBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
                }
                else
                {
                    MessageBox.Show("Data berhasil ditambah");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }
    }
}
