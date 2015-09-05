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
    public partial class KurirUI : Form
    {
        Kurir s_Kurir;
        KurirManager s_KurirManager;
        private BindingSource s_BindingKurir = new BindingSource();

        public KurirUI()
        {
            InitializeComponent();
            s_KurirManager = new KurirManager();
            txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
            DisplayKurir();
        }

        private void btn_AddKurir_Click(object sender, EventArgs e)
        {
            if (txt_NamaKurir.TextLength > 0 && txt_NoTelpKurir.TextLength > 0 && txt_AlamatKurir.TextLength > 0)
            {

                s_Kurir = new Kurir(Utils.ConcatMaxID(txt_IdKurir.Text.ToString(),txt_IdKurirNum.Text.ToString()), txt_NamaKurir.Text.ToString(), txt_NoTelpKurir.Text.ToString(), txt_AlamatKurir.Text.ToString());
                if (s_KurirManager.AddKurir(s_Kurir))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
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

        private void btn_EditKurir_Click(object sender, EventArgs e)
        {
            if (txt_NamaKurir.TextLength > 0 && txt_NoTelpKurir.TextLength > 0 && txt_AlamatKurir.TextLength > 0)
            {
                s_Kurir = new Kurir(Utils.ConcatMaxID(txt_IdKurir.Text.ToString(), txt_IdKurirNum.Text.ToString()), txt_NamaKurir.Text.ToString(), txt_NoTelpKurir.Text.ToString(), txt_AlamatKurir.Text.ToString());
                if (s_KurirManager.UpdateKurir(s_Kurir))
                {
                    MessageBox.Show("Data berhasil diubah");
                    txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
                    ClearField();
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

        private void btn_DeleteKurir_Click(object sender, EventArgs e)
        {
            if (txt_NamaKurir.TextLength > 0 && txt_NoTelpKurir.TextLength > 0 && txt_AlamatKurir.TextLength > 0)
            {
                s_Kurir = new Kurir(Utils.ConcatMaxID(txt_IdKurir.Text.ToString(), txt_IdKurirNum.Text.ToString()), txt_NamaKurir.Text.ToString(), txt_NoTelpKurir.Text.ToString(), txt_AlamatKurir.Text.ToString());
                if (s_KurirManager.DeleteKurir(s_Kurir))
                {
                    MessageBox.Show("Data berhasil dihapus");
                    txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
                    ClearField();
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

        private void btn_HapusPermanen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan! Anda akan menghapus semua data secara permanen. Anda yakin?", "WARNING", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                s_Kurir = new Kurir();
                s_Kurir.Id_kurir = Utils.ConcatMaxID(txt_IdKurir.Text.ToString(), txt_IdKurirNum.Text.ToString());

                if (s_KurirManager.DeleteKurirPermanen(s_Kurir))
                {
                    MessageBox.Show("Data berhasil dihapus permanen");
                    txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
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
                if (s_KurirManager.RestoreData())
                {
                    MessageBox.Show("Data berhasil dipulihkan");
                    txt_IdKurirNum.Text = Utils.DisplayMaxID(s_KurirManager.GetMaxIDKurir().Substring((s_KurirManager.GetMaxIDKurir().IndexOf("-")) + 1));
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

        private void DisplayKurir()
        {
            s_BindingKurir.DataSource = s_KurirManager.GetDataKurir().Tables[0];
            s_BindingKurir.Filter = string.Empty;
            dg_DisplayKurir.DataSource = s_BindingKurir;
        }

        private void DisplayKurirSearch(string name)
        {
            s_BindingKurir.DataSource = s_KurirManager.GetDataKurirByName(name).Tables[0];
            s_BindingKurir.Filter = string.Empty;
            dg_DisplayKurir.DataSource = s_BindingKurir;
        }

        private void dg_DisplayKurir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdKurirNum.Text = dg_DisplayKurir[0, currentRow].Value.ToString().Substring(dg_DisplayKurir[0, currentRow].Value.ToString().IndexOf("-") + 1);
                    txt_NamaKurir.Text = dg_DisplayKurir[1, currentRow].Value.ToString();
                    txt_AlamatKurir.Text = dg_DisplayKurir[2, currentRow].Value.ToString();
                    txt_NoTelpKurir.Text = dg_DisplayKurir[3, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data kurir : "+ex, "Error");
            }
        }

        private void ClearField()
        {
            txt_NamaKurir.Text = String.Empty;
            txt_AlamatKurir.Text = String.Empty;
            txt_NoTelpKurir.Text = String.Empty;
            DisplayKurir();
        }

        private void KurirUI_TextChanged(object sender, EventArgs e)
        {
            DisplayKurirSearch(txt_SearchKurir.Text.ToString());
        }
    }
}
