namespace GrazieeProject.View
{
    partial class KurirUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_PulihkanData = new System.Windows.Forms.Button();
            this.btn_HapusPermanen = new System.Windows.Forms.Button();
            this.btn_DeleteKurir = new System.Windows.Forms.Button();
            this.btn_EditKurir = new System.Windows.Forms.Button();
            this.btn_AddKurir = new System.Windows.Forms.Button();
            this.txt_NoTelpKurir = new System.Windows.Forms.TextBox();
            this.txt_AlamatKurir = new System.Windows.Forms.TextBox();
            this.txt_NamaKurir = new System.Windows.Forms.TextBox();
            this.txt_IdKurir = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_DisplayKurir = new System.Windows.Forms.DataGridView();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.lblAlamatPelanggan = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblIdPelanggan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdKurirNum = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayKurir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PulihkanData
            // 
            this.btn_PulihkanData.Location = new System.Drawing.Point(202, 335);
            this.btn_PulihkanData.Name = "btn_PulihkanData";
            this.btn_PulihkanData.Size = new System.Drawing.Size(100, 23);
            this.btn_PulihkanData.TabIndex = 12;
            this.btn_PulihkanData.Text = "Pulihkan Data";
            this.btn_PulihkanData.UseVisualStyleBackColor = true;
            this.btn_PulihkanData.Click += new System.EventHandler(this.btn_PulihkanData_Click);
            // 
            // btn_HapusPermanen
            // 
            this.btn_HapusPermanen.Location = new System.Drawing.Point(43, 335);
            this.btn_HapusPermanen.Name = "btn_HapusPermanen";
            this.btn_HapusPermanen.Size = new System.Drawing.Size(118, 23);
            this.btn_HapusPermanen.TabIndex = 11;
            this.btn_HapusPermanen.Text = "Hapus Permanen";
            this.btn_HapusPermanen.UseVisualStyleBackColor = true;
            this.btn_HapusPermanen.Click += new System.EventHandler(this.btn_HapusPermanen_Click);
            // 
            // btn_DeleteKurir
            // 
            this.btn_DeleteKurir.Location = new System.Drawing.Point(242, 274);
            this.btn_DeleteKurir.Name = "btn_DeleteKurir";
            this.btn_DeleteKurir.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteKurir.TabIndex = 10;
            this.btn_DeleteKurir.Text = "Hapus Data";
            this.btn_DeleteKurir.UseVisualStyleBackColor = true;
            this.btn_DeleteKurir.Click += new System.EventHandler(this.btn_DeleteKurir_Click);
            // 
            // btn_EditKurir
            // 
            this.btn_EditKurir.Location = new System.Drawing.Point(149, 274);
            this.btn_EditKurir.Name = "btn_EditKurir";
            this.btn_EditKurir.Size = new System.Drawing.Size(75, 23);
            this.btn_EditKurir.TabIndex = 9;
            this.btn_EditKurir.Text = "Ubah Data";
            this.btn_EditKurir.UseVisualStyleBackColor = true;
            this.btn_EditKurir.Click += new System.EventHandler(this.btn_EditKurir_Click);
            // 
            // btn_AddKurir
            // 
            this.btn_AddKurir.Location = new System.Drawing.Point(32, 274);
            this.btn_AddKurir.Name = "btn_AddKurir";
            this.btn_AddKurir.Size = new System.Drawing.Size(95, 23);
            this.btn_AddKurir.TabIndex = 8;
            this.btn_AddKurir.Text = "Tambah Data";
            this.btn_AddKurir.UseVisualStyleBackColor = true;
            this.btn_AddKurir.Click += new System.EventHandler(this.btn_AddKurir_Click);
            // 
            // txt_NoTelpKurir
            // 
            this.txt_NoTelpKurir.Location = new System.Drawing.Point(149, 182);
            this.txt_NoTelpKurir.Name = "txt_NoTelpKurir";
            this.txt_NoTelpKurir.Size = new System.Drawing.Size(153, 20);
            this.txt_NoTelpKurir.TabIndex = 7;
            // 
            // txt_AlamatKurir
            // 
            this.txt_AlamatKurir.Location = new System.Drawing.Point(149, 136);
            this.txt_AlamatKurir.Name = "txt_AlamatKurir";
            this.txt_AlamatKurir.Size = new System.Drawing.Size(158, 20);
            this.txt_AlamatKurir.TabIndex = 6;
            // 
            // txt_NamaKurir
            // 
            this.txt_NamaKurir.Location = new System.Drawing.Point(149, 90);
            this.txt_NamaKurir.Name = "txt_NamaKurir";
            this.txt_NamaKurir.Size = new System.Drawing.Size(156, 20);
            this.txt_NamaKurir.TabIndex = 5;
            // 
            // txt_IdKurir
            // 
            this.txt_IdKurir.Location = new System.Drawing.Point(149, 56);
            this.txt_IdKurir.Name = "txt_IdKurir";
            this.txt_IdKurir.ReadOnly = true;
            this.txt_IdKurir.Size = new System.Drawing.Size(75, 20);
            this.txt_IdKurir.TabIndex = 4;
            this.txt_IdKurir.Text = "KUR-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_DisplayKurir);
            this.groupBox2.Location = new System.Drawing.Point(350, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 420);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampilan Data";
            // 
            // dg_DisplayKurir
            // 
            this.dg_DisplayKurir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DisplayKurir.Location = new System.Drawing.Point(35, 19);
            this.dg_DisplayKurir.Name = "dg_DisplayKurir";
            this.dg_DisplayKurir.Size = new System.Drawing.Size(355, 372);
            this.dg_DisplayKurir.TabIndex = 0;
            this.dg_DisplayKurir.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DisplayKurir_CellContentClick);
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Location = new System.Drawing.Point(40, 182);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(53, 13);
            this.lblNoTelp.TabIndex = 3;
            this.lblNoTelp.Text = "NO TELP";
            // 
            // lblAlamatPelanggan
            // 
            this.lblAlamatPelanggan.AutoSize = true;
            this.lblAlamatPelanggan.Location = new System.Drawing.Point(40, 136);
            this.lblAlamatPelanggan.Name = "lblAlamatPelanggan";
            this.lblAlamatPelanggan.Size = new System.Drawing.Size(87, 13);
            this.lblAlamatPelanggan.TabIndex = 2;
            this.lblAlamatPelanggan.Text = "ALAMAT KURIR";
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(40, 98);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(75, 13);
            this.lblNamaPelanggan.TabIndex = 1;
            this.lblNamaPelanggan.Text = "NAMA KURIR";
            // 
            // lblIdPelanggan
            // 
            this.lblIdPelanggan.AutoSize = true;
            this.lblIdPelanggan.Location = new System.Drawing.Point(40, 59);
            this.lblIdPelanggan.Name = "lblIdPelanggan";
            this.lblIdPelanggan.Size = new System.Drawing.Size(55, 13);
            this.lblIdPelanggan.TabIndex = 0;
            this.lblIdPelanggan.Text = "ID KURIR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdKurirNum);
            this.groupBox1.Controls.Add(this.btn_PulihkanData);
            this.groupBox1.Controls.Add(this.btn_HapusPermanen);
            this.groupBox1.Controls.Add(this.btn_DeleteKurir);
            this.groupBox1.Controls.Add(this.btn_EditKurir);
            this.groupBox1.Controls.Add(this.btn_AddKurir);
            this.groupBox1.Controls.Add(this.txt_NoTelpKurir);
            this.groupBox1.Controls.Add(this.txt_AlamatKurir);
            this.groupBox1.Controls.Add(this.txt_NamaKurir);
            this.groupBox1.Controls.Add(this.txt_IdKurir);
            this.groupBox1.Controls.Add(this.lblNoTelp);
            this.groupBox1.Controls.Add(this.lblAlamatPelanggan);
            this.groupBox1.Controls.Add(this.lblNamaPelanggan);
            this.groupBox1.Controls.Add(this.lblIdPelanggan);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 425);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txtIdKurirNum
            // 
            this.txtIdKurirNum.Location = new System.Drawing.Point(232, 56);
            this.txtIdKurirNum.Name = "txtIdKurirNum";
            this.txtIdKurirNum.ReadOnly = true;
            this.txtIdKurirNum.Size = new System.Drawing.Size(73, 20);
            this.txtIdKurirNum.TabIndex = 13;
            // 
            // KurirUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KurirUI";
            this.Text = "Pengelolaan Kurir";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayKurir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PulihkanData;
        private System.Windows.Forms.Button btn_HapusPermanen;
        private System.Windows.Forms.Button btn_DeleteKurir;
        private System.Windows.Forms.Button btn_EditKurir;
        private System.Windows.Forms.Button btn_AddKurir;
        private System.Windows.Forms.TextBox txt_NoTelpKurir;
        private System.Windows.Forms.TextBox txt_AlamatKurir;
        private System.Windows.Forms.TextBox txt_NamaKurir;
        private System.Windows.Forms.TextBox txt_IdKurir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_DisplayKurir;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label lblAlamatPelanggan;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblIdPelanggan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtIdKurirNum;

    }
}