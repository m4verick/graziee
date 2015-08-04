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
    public partial class ModelBarangUI : Form
    {
        ModelBarang s_ModelBarang;
        WarnaMerekModelUkuranManager s_ModeBarangManager;

        public ModelBarangUI()
        {
            InitializeComponent();
            s_ModeBarangManager = new WarnaMerekModelUkuranManager();
        }

        private void btn_AddModelBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaModelBarang.TextLength > 0)
            {
                s_ModelBarang = new ModelBarang(txt_IdModelBarang.Text.ToString(), txt_NamaModelBarang.Text.ToString());
                if (s_ModeBarangManager.AddModel(s_ModelBarang))
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
