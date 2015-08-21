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
            pb_BarcodeImage.Image = barcode.drawBarcode();
        }

        private void btn_AddBarang_Click(object sender, EventArgs e)
        {
            generateBarcode();
        } 
    }
}
