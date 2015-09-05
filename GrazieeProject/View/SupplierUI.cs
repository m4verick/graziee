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
            txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
            DisplaySupplier();
        }

        private void btn_AddSupplier_Click(object sender, EventArgs e)
        {
            if (txt_NamaSupplier.TextLength > 0 && txt_AlamatSupplier.TextLength > 0 && txt_NoTelpSupplier.TextLength > 0)
            {
                s_Supplier = new Supplier(Utils.ConcatMaxID(txt_IdSupplier.Text.ToString(),txt_IdSupplierNum.Text.ToString()), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.AddSupplier(s_Supplier))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
                    ClearField();
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
                s_Supplier = new Supplier(Utils.ConcatMaxID(txt_IdSupplier.Text.ToString(), txt_IdSupplierNum.Text.ToString()), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.UpdateSupplier(s_Supplier))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
                    ClearField();
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
                s_Supplier = new Supplier(Utils.ConcatMaxID(txt_IdSupplier.Text.ToString(), txt_IdSupplierNum.Text.ToString()), txt_NamaSupplier.Text.ToString(), txt_AlamatSupplier.TextLength.ToString(), txt_NoTelpSupplier.Text.ToString());
                if (s_SupplierManager.DeleteSupplier(s_Supplier))
                {                    
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
                    ClearField();
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
                s_Supplier.Id_supplier = Utils.ConcatMaxID(txt_IdSupplier.Text.ToString(), txt_IdSupplierNum.Text.ToString());

                if (s_SupplierManager.DeleteSupplierPermanen(s_Supplier))
                {
                    MessageBox.Show("Data berhasil dihapus permanen");
                    txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
                    ClearField();
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
                    txt_IdSupplierNum.Text = Utils.DisplayMaxID(s_SupplierManager.GetMaxIDSupp().Substring(s_SupplierManager.GetMaxIDSupp().IndexOf("-") + 1));
                    ClearField();
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

        private void DisplaySupplierSearch(string name)
        {
            s_BindingSupplier.DataSource = s_SupplierManager.GetDataSupplierByName(name).Tables[0];
            s_BindingSupplier.Filter = string.Empty;
            dg_DisplaySupplier.DataSource = s_BindingSupplier;
        }

        private void dg_DisplaySupplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdSupplierNum.Text = dg_DisplaySupplier[0, currentRow].Value.ToString().Substring(dg_DisplaySupplier[0, currentRow].Value.ToString().IndexOf("-") + 1);
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

        private void ClearField()
        {
            txt_NamaSupplier.Text = String.Empty;
            txt_AlamatSupplier.Text = String.Empty;
            txt_NoTelpSupplier.Text = String.Empty;
            DisplaySupplier();
        }

        private void txt_SearchSuplier_TextChanged(object sender, EventArgs e)
        {
            DisplaySupplierSearch(txt_SearchSuplier.Text.ToString());
        }
    }
}
