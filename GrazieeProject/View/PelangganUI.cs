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
    public partial class PelangganUI : Form
    {
        private Pelanggan s_Pelanggan;
        private PelangganManager s_PelangganManager;
        private BindingSource s_BindingPelanggan = new BindingSource();

        public PelangganUI()
        {
            InitializeComponent();
            s_PelangganManager = new PelangganManager();
            DisplayPelanggan();
        }

        private void btn_AddPelanggan_Click(object sender, EventArgs e)
        {
            if (txt_NamaPelanggan.TextLength > 0 && txt_AlamatPelanggan.TextLength > 0 && txt_NoTelpPelanggan.TextLength > 0)
            {
                s_Pelanggan = new Pelanggan(txt_IdPelanggan.Text.ToString(), txt_NamaPelanggan.Text.ToString(), txt_AlamatPelanggan.TextLength.ToString(), txt_NoTelpPelanggan.Text.ToString());
                if (s_PelangganManager.AddPelanggan(s_Pelanggan))
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

        private void btn_EditPelanggan_Click(object sender, EventArgs e)
        {
            //commented out for a while
            /*
            if (!s_PelangganManager.CheckIdPelanggan(txt_IdPelanggan.Text.ToString()))
            {
                MessageBox.Show("Id Pelanggan tidak ditemukan");
                return;
            }
            */

            if (txt_NamaPelanggan.TextLength > 0 && txt_AlamatPelanggan.TextLength > 0 && txt_NoTelpPelanggan.TextLength > 0)
            {
                s_Pelanggan = new Pelanggan(txt_IdPelanggan.Text.ToString(), txt_NamaPelanggan.Text.ToString(), txt_AlamatPelanggan.TextLength.ToString(), txt_NoTelpPelanggan.Text.ToString());
                if (s_PelangganManager.UpdatePelanggan(s_Pelanggan))
                {
                    MessageBox.Show("Data berhasil diubah");
                }
                else
                {
                    MessageBox.Show("Data gagal diubah");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }

        private void btn_DeletePelanggan_Click(object sender, EventArgs e)
        {
            if (txt_NamaPelanggan.TextLength > 0 && txt_AlamatPelanggan.TextLength > 0 && txt_NoTelpPelanggan.TextLength > 0)
            {
                s_Pelanggan = new Pelanggan(txt_IdPelanggan.Text.ToString(), txt_NamaPelanggan.Text.ToString(), txt_AlamatPelanggan.TextLength.ToString(), txt_NoTelpPelanggan.Text.ToString());
                if (s_PelangganManager.DeletePelanggan(s_Pelanggan))
                {
                    MessageBox.Show("Data berhasil dihapus");
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus");
                }
            }
            else
            {
                MessageBox.Show("Mohon data-data dilengkapi");
            }
        }

        private void btn_PulihkanData_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan memulihkan semua data yang pernah dihapus. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (s_PelangganManager.RestoreData())
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

        private void btn_HapusPermanen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan menghapus semua data secara permanen. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                s_Pelanggan = new Pelanggan();
                s_Pelanggan.Id_pelanggan = txt_IdPelanggan.Text.ToString();

                if (s_PelangganManager.DeletePelangganPermanen(s_Pelanggan))
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

        private void DisplayPelanggan()
        {
            s_BindingPelanggan.DataSource = s_PelangganManager.GetDataPelanggan().Tables[0];
            s_BindingPelanggan.Filter = string.Empty;
            dg_DisplayPelanggan.DataSource = s_BindingPelanggan;
        }

        private void dg_DisplayPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdPelanggan.Text = dg_DisplayPelanggan[0, currentRow].Value.ToString();
                    txt_NamaPelanggan.Text = dg_DisplayPelanggan[1, currentRow].Value.ToString();
                    txt_AlamatPelanggan.Text = dg_DisplayPelanggan[2, currentRow].Value.ToString();
                    txt_NoTelpPelanggan.Text = dg_DisplayPelanggan[3, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data pelanggan", "Error");
            }
        }

        private void dg_DisplayPelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO
        }
    }
}
