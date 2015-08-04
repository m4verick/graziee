using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrazieeProject.Model;
using GrazieeProject.View;

namespace GrazieeProject.View
{
    public partial class BarangUI : Form
    {
        public BarangUI()
        {
            InitializeComponent();
        }

        private void btn_SearchSupplier_Click(object sender, EventArgs e)
        {
            SupplierUI s_SupplierUI = new SupplierUI();
            s_SupplierUI.Show();
        }

        private void btn_SearchMerekBarang_Click(object sender, EventArgs e)
        {
            MerekBarangUI s_MerekBarangUI = new MerekBarangUI();
            s_MerekBarangUI.Show();
        }

        private void btn_SearchWarnaBarang_Click(object sender, EventArgs e)
        {
            WarnaBarangUI s_WarnaBarangUI = new WarnaBarangUI();
            s_WarnaBarangUI.Show();
        }

        private void btn_SearchModelBarang_Click(object sender, EventArgs e)
        {
            ModelBarangUI s_ModelBarangUI = new ModelBarangUI();
            s_ModelBarangUI.Show();
        }
    }
}
