using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrazieeProject.View
{
    public partial class MainUI : Form
    {
        private string m_roleMain = String.Empty;

        public MainUI(string role)
        {
            InitializeComponent();
            m_roleMain = role;
        }

        private bool IsAlreadyActivated(Type formType)
        {
            if (this.MdiChildren.GetLength(0) > 0)
            {
                foreach (Form childForm in this.MdiChildren)
                {
                    if (childForm.GetType().Equals(formType))
                        return true;
                }
            }
            return false;
        }


        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void pengelolaanPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(PelangganUI)))
                {
                    PelangganUI s_PelangganUI = new PelangganUI();
                    s_PelangganUI.MdiParent = this;
                    s_PelangganUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil Pelanggan UI : " + el.Message, "Informasi");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Anda yakin untuk keluar?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    Application.Exit();
            }
            catch (Exception exi)
            {
                MessageBox.Show("Gagal Exit : " + exi.Message, "Informasi");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Anda yakin untuk Logout?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Hide();
                    LoginUI s_LoginUI = new LoginUI();
                    s_LoginUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Logout : " + el.Message, "Informasi");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(AboutUI)))
                {
                    AboutUI s_AboutUI = new AboutUI();
                    s_AboutUI.MdiParent = this;
                    s_AboutUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil About UI : " + el.Message, "Informasi");
            }
        }

        private void pengelolaanUserSistemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(UserSistemUI)))
                {
                    UserSistemUI s_UserSistemUI = new UserSistemUI();
                    s_UserSistemUI.MdiParent = this;
                    s_UserSistemUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil UserSistem UI : " + el.Message, "Informasi");
            }
        }

        private void pengelolaanKurirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(KurirUI)))
                {
                    KurirUI s_KurirUI = new KurirUI();
                    s_KurirUI.MdiParent = this;
                    s_KurirUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil Kurir UI : " + el.Message, "Informasi");
            }
        }

        private void pengelolaanSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(SupplierUI)))
                {
                    SupplierUI s_SupplierUI = new SupplierUI();
                    s_SupplierUI.MdiParent = this;
                    s_SupplierUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil Supplier UI : " + el.Message, "Informasi");
            }
        }

        private void pengelolaanBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsAlreadyActivated(typeof(BarangUI)))
                {
                    BarangUI s_BarangUI = new BarangUI();
                    s_BarangUI.MdiParent = this;
                    s_BarangUI.Show();
                }
            }
            catch (Exception el)
            {
                MessageBox.Show("Gagal Tampil Barang UI : " + el.Message, "Informasi");
            }
        }
    }
}
