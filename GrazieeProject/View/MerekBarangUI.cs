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
        private MerekBarang s_MerekBarang;
        private ModelBarang s_ModelBarang;
        private UkuranBarang s_UkuranBarang;
        private WarnaBarang s_WarnaBarang;

        private WarnaMerekModelUkuranManager s_MerekBarangManager;

        private BindingSource s_BindingMerek = new BindingSource();
        private BindingSource s_BindingModel = new BindingSource();
        private BindingSource s_BindingWarna = new BindingSource();
        private BindingSource s_BindingUkuran = new BindingSource();

        public MerekBarangUI()
        {
            InitializeComponent();
            s_MerekBarangManager = new WarnaMerekModelUkuranManager();
        }

        #region MerekBarang
        private void btn_AddMerekBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaMerekBarang.TextLength > 0)
            {
                s_MerekBarang = new MerekBarang(Utils.ConcatMaxID(txt_IdMerekBarang.Text.ToString(), txt_IdMerekBarangNum.Text.ToString()), txt_NamaMerekBarang.Text.ToString());
                if (s_MerekBarangManager.AddMerek(s_MerekBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdMerekBarangNum.Text = Utils.DisplayMaxID(s_MerekBarangManager.GetMaxIDMerekBarang().Substring((s_MerekBarangManager.GetMaxIDMerekBarang().IndexOf("-")) + 1));
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

        private void dgv_MerekBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdMerekBarangNum.Text = dgv_MerekBarang[0, currentRow].Value.ToString().Substring(dgv_MerekBarang[0, currentRow].Value.ToString().IndexOf("-") + 1);
                    txt_NamaMerekBarang.Text = dgv_MerekBarang[1, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data Merek : " + ex, "Error");
            }
        }

        private void DisplayMerekBarang()
        {
            s_BindingMerek.DataSource = s_MerekBarangManager.GetDataMerek().Tables[0];
            s_BindingMerek.Filter = string.Empty;
            dgv_MerekBarang.DataSource = s_BindingMerek; 
        }
        #endregion

        #region ModelBarang
        private void btn_AddModelBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaModelBarang.TextLength > 0)
            {
                s_ModelBarang = new ModelBarang(Utils.ConcatMaxID(txt_IdModelBarang.Text.ToString(), txt_IdModelBarangNum.Text.ToString()), txt_NamaModelBarang.Text.ToString());
                if (s_MerekBarangManager.AddModel(s_ModelBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdModelBarangNum.Text = Utils.DisplayMaxID(s_MerekBarangManager.GetMaxIDModelBarang().Substring((s_MerekBarangManager.GetMaxIDModelBarang().IndexOf("-")) + 1));
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

        private void dgv_ModelBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdModelBarangNum.Text = dgv_ModelBarang[0, currentRow].Value.ToString().Substring(dgv_ModelBarang[0, currentRow].Value.ToString().IndexOf("-") + 1);
                    txt_NamaModelBarang.Text = dgv_ModelBarang[1, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data Model : " + ex, "Error");
            }
        }

        private void DisplayModelBarang()
        {
            s_BindingModel.DataSource = s_MerekBarangManager.GetDataModel().Tables[0];
            s_BindingModel.Filter = string.Empty;
            dgv_ModelBarang.DataSource = s_BindingModel;
        }
        #endregion

        #region WarnaBarang
        private void btn_AddWarnaBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaWarnaBarang.TextLength > 0)
            {
                s_WarnaBarang = new WarnaBarang(Utils.ConcatMaxID(txt_IdWarnaBarang.Text.ToString(), txt_IdWarnaBarangNum.Text.ToString()), txt_NamaWarnaBarang.Text.ToString());
                if (s_MerekBarangManager.AddWarna(s_WarnaBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdWarnaBarangNum.Text = Utils.DisplayMaxID(s_MerekBarangManager.GetMaxIDWarnaBarang().Substring((s_MerekBarangManager.GetMaxIDWarnaBarang().IndexOf("-")) + 1));
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

        private void dgv_WarnaBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdWarnaBarangNum.Text = dgv_WarnaBarang[0, currentRow].Value.ToString().Substring(dgv_WarnaBarang[0, currentRow].Value.ToString().IndexOf("-") + 1);
                    txt_NamaWarnaBarang.Text = dgv_WarnaBarang[1, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data warna : " + ex, "Error");
            }
        }

        private void DisplayWarnaBarang()
        {
            s_BindingWarna.DataSource = s_MerekBarangManager.GetDataWarna().Tables[0];
            s_BindingWarna.Filter = string.Empty;
            dgv_WarnaBarang.DataSource = s_BindingWarna;
        }
        #endregion

        #region UkuranBarang
        private void btn_AddUkuranBarang_Click(object sender, EventArgs e)
        {
            if (txt_NamaUkuranBarang.TextLength > 0)
            {
                s_UkuranBarang = new UkuranBarang(Utils.ConcatMaxID(txt_IdUkuranBarang.Text.ToString(), txt_IdUkuranBarangNum.Text.ToString()), txt_NamaUkuranBarang.Text.ToString());
                if (s_MerekBarangManager.AddUkuran(s_UkuranBarang))
                {
                    MessageBox.Show("Data berhasil ditambah");
                    txt_IdUkuranBarangNum.Text = Utils.DisplayMaxID(s_MerekBarangManager.GetMaxIDUkuranBarang().Substring((s_MerekBarangManager.GetMaxIDUkuranBarang().IndexOf("-")) + 1));
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

        private void dgv_UkuranBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                if (e.RowIndex > -1)
                {
                    txt_IdUkuranBarangNum.Text = dgv_UkuranBarang[0, currentRow].Value.ToString().Substring(dgv_UkuranBarang[0, currentRow].Value.ToString().IndexOf("-") + 1);
                    txt_NamaUkuranBarang.Text = dgv_UkuranBarang[1, currentRow].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal get data kurir : " + ex, "Error");
            }
        }

        private void DisplayUkuranBarang()
        {
            s_BindingUkuran.DataSource = s_MerekBarangManager.GetDataUkuran().Tables[0];
            s_BindingUkuran.Filter = string.Empty;
            dgv_UkuranBarang.DataSource = s_BindingUkuran;
        }
        #endregion
    }
}
