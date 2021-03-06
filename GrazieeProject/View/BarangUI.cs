﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GrazieeProject.Model;
using GrazieeProject.Control;
using GrazieeProject.View;

namespace GrazieeProject.View
{
    public partial class BarangUI : Form
    {
        Barang s_Barang;
        BarangManager s_BarangManager;
        private BindingSource s_BindingBarang = new BindingSource();

        #region SetGet_TextBox
        public TextBox SupplierName
        {
            get { return this.txt_SupplierName; }
        }

        public TextBox MerekName
        {
            get { return this.txt_MerekName; }
        }

        public TextBox WarnaName
        {
            get { return this.txt_WarnaName; }
        }

        public TextBox ModelName
        {
            get { return this.txt_ModelName; }
        }

        public TextBox UkuranName
        {
            get { return this.txt_UkuranName; }
        }

        public TextBox JenisName
        {
            get { return this.txt_JenisName; }
        }
        #endregion

        public BarangUI()
        {
            InitializeComponent();
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

        }

        private void btn_CariSupplierBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.SUPPLIER);
            disp.Show();
        }

        private void btn_CariMerekBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.MEREK_BARANG);
            disp.Show();
        }

        private void btn_CariWarnaBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.WARNA_BARANG);
            disp.Show();
        }

        private void btn_CariModelBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.MODEL_BARANG);
            disp.Show();
        }

        private void btn_CariUkuranBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.UKURAN_BARANG);
            disp.Show();
        }

        private void btn_CariJenisBarang_Click(object sender, EventArgs e)
        {
            DisplayAll disp = new DisplayAll(Utils.ClassSelector.JENIS_BARANG);
            disp.Show();
        } 
    }
}
