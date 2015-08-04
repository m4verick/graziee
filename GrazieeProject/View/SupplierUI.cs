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
    public partial class SupplierUI : Form
    {
        private Supplier s_Supplier;
        private SupplierManager s_SupplierManager;
        private BindingSource s_BindingSupplier = new BindingSource();

        public SupplierUI()
        {
            InitializeComponent();
            s_SupplierManager = new SupplierManager();
            DisplaySupplier();
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            if (txt_NamaSupplier.TextLength > 0 && txt_AlamatSupplier.TextLength > 0 && txt_NoTelpSupplier.TextLength > 0)
            {
                s_Supplier = new Supplier(txt_IdSupplier.Text.ToString(), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.AddSupplier(s_Supplier))
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

        private void btn_EditSupplier_Click(object sender, EventArgs e)
        {
            if (txt_NamaSupplier.TextLength > 0 && txt_AlamatSupplier.TextLength > 0 && txt_NoTelpSupplier.TextLength > 0)
            {
                s_Supplier = new Supplier(txt_IdSupplier.Text.ToString(), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.UpdateSupplier(s_Supplier))
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

        private void btn_DeleteSupplier_Click(object sender, EventArgs e)
        {
            if (txt_NamaSupplier.TextLength > 0 && txt_AlamatSupplier.TextLength > 0 && txt_NoTelpSupplier.TextLength > 0)
            {
                s_Supplier = new Supplier(txt_IdSupplier.Text.ToString(), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.DeleteSupplier(s_Supplier))
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

        private void btn_HapusPermanen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan menghapus semua data secara permanen. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                s_Supplier = new Supplier();
                s_Supplier.Id_supplier = txt_IdSupplier.Text.ToString();

                if (s_SupplierManager.DeleteSupplierPermanen(s_Supplier))
                {
                    MessageBox.Show("Data berhasil dihapus permanen");
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

        private void btn_PulihkanData_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan memulihkan semua data yang pernah dihapus. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (s_SupplierManager.RestoreData())
                {
                    MessageBox.Show("Data berhasil dipulihkan");
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

        private void DisplaySupplier()
        {
            s_BindingSupplier.DataSource = s_SupplierManager.GetDataSupplier().Tables[0];
            s_BindingSupplier.Filter = string.Empty;
            dg_DisplaySupplier.DataSource = s_BindingSupplier;
        }

        private void dg_DisplaySupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdSupplier.Text = dg_DisplaySupplier[0, currentRow].Value.ToString();
                    txt_NamaSupplier.Text = dg_DisplaySupplier[1, currentRow].Value.ToString();
                    txt_AlamatSupplier.Text = dg_DisplaySupplier[2, currentRow].Value.ToString();
                    txt_NoTelpSupplier.Text = dg_DisplaySupplier[3, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data supplier", "Error");
            }
        }
    }
}
