namespace GrazieeProject.View
{
    partial class PelangganUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_PulihkanData = new System.Windows.Forms.Button();
            this.btn_HapusPermanen = new System.Windows.Forms.Button();
            this.btn_DeletePelanggan = new System.Windows.Forms.Button();
            this.btn_EditPelanggan = new System.Windows.Forms.Button();
            this.btn_AddPelanggan = new System.Windows.Forms.Button();
            this.txt_NoTelpPelanggan = new System.Windows.Forms.TextBox();
            this.txt_AlamatPelanggan = new System.Windows.Forms.TextBox();
            this.txt_NamaPelanggan = new System.Windows.Forms.TextBox();
            this.txt_IdPelanggan = new System.Windows.Forms.TextBox();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.lblAlamatPelanggan = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblIdPelanggan = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_DisplayPelanggan = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_PulihkanData);
            this.groupBox1.Controls.Add(this.btn_HapusPermanen);
            this.groupBox1.Controls.Add(this.btn_DeletePelanggan);
            this.groupBox1.Controls.Add(this.btn_EditPelanggan);
            this.groupBox1.Controls.Add(this.btn_AddPelanggan);
            this.groupBox1.Controls.Add(this.txt_NoTelpPelanggan);
            this.groupBox1.Controls.Add(this.txt_AlamatPelanggan);
            this.groupBox1.Controls.Add(this.txt_NamaPelanggan);
            this.groupBox1.Controls.Add(this.txt_IdPelanggan);
            this.groupBox1.Controls.Add(this.lblNoTelp);
            this.groupBox1.Controls.Add(this.lblAlamatPelanggan);
            this.groupBox1.Controls.Add(this.lblNamaPelanggan);
            this.groupBox1.Controls.Add(this.lblIdPelanggan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // btn_PulihkanData
            // 
            this.btn_PulihkanData.Location = new System.Drawing.Point(183, 335);
            this.btn_PulihkanData.Name = "btn_PulihkanData";
            this.btn_PulihkanData.Size = new System.Drawing.Size(100, 23);
            this.btn_PulihkanData.TabIndex = 12;
            this.btn_PulihkanData.Text = "Pulihkan Data";
            this.btn_PulihkanData.UseVisualStyleBackColor = true;
            this.btn_PulihkanData.Click += new System.EventHandler(this.btn_PulihkanData_Click);
            // 
            // btn_HapusPermanen
            // 
            this.btn_HapusPermanen.Location = new System.Drawing.Point(24, 335);
            this.btn_HapusPermanen.Name = "btn_HapusPermanen";
            this.btn_HapusPermanen.Size = new System.Drawing.Size(118, 23);
            this.btn_HapusPermanen.TabIndex = 11;
            this.btn_HapusPermanen.Text = "Hapus Permanen";
            this.btn_HapusPermanen.UseVisualStyleBackColor = true;
            this.btn_HapusPermanen.Click += new System.EventHandler(this.btn_HapusPermanen_Click);
            // 
            // btn_DeletePelanggan
            // 
            this.btn_DeletePelanggan.Location = new System.Drawing.Point(223, 274);
            this.btn_DeletePelanggan.Name = "btn_DeletePelanggan";
            this.btn_DeletePelanggan.Size = new System.Drawing.Size(75, 23);
            this.btn_DeletePelanggan.TabIndex = 10;
            this.btn_DeletePelanggan.Text = "Hapus Data";
            this.btn_DeletePelanggan.UseVisualStyleBackColor = true;
            this.btn_DeletePelanggan.Click += new System.EventHandler(this.btn_DeletePelanggan_Click);
            // 
            // btn_EditPelanggan
            // 
            this.btn_EditPelanggan.Location = new System.Drawing.Point(130, 274);
            this.btn_EditPelanggan.Name = "btn_EditPelanggan";
            this.btn_EditPelanggan.Size = new System.Drawing.Size(75, 23);
            this.btn_EditPelanggan.TabIndex = 9;
            this.btn_EditPelanggan.Text = "Ubah Data";
            this.btn_EditPelanggan.UseVisualStyleBackColor = true;
            this.btn_EditPelanggan.Click += new System.EventHandler(this.btn_EditPelanggan_Click);
            // 
            // btn_AddPelanggan
            // 
            this.btn_AddPelanggan.Location = new System.Drawing.Point(13, 274);
            this.btn_AddPelanggan.Name = "btn_AddPelanggan";
            this.btn_AddPelanggan.Size = new System.Drawing.Size(95, 23);
            this.btn_AddPelanggan.TabIndex = 8;
            this.btn_AddPelanggan.Text = "Tambah Data";
            this.btn_AddPelanggan.UseVisualStyleBackColor = true;
            this.btn_AddPelanggan.Click += new System.EventHandler(this.btn_AddPelanggan_Click);
            // 
            // txt_NoTelpPelanggan
            // 
            this.txt_NoTelpPelanggan.Location = new System.Drawing.Point(183, 182);
            this.txt_NoTelpPelanggan.Name = "txt_NoTelpPelanggan";
            this.txt_NoTelpPelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_NoTelpPelanggan.TabIndex = 7;
            // 
            // txt_AlamatPelanggan
            // 
            this.txt_AlamatPelanggan.Location = new System.Drawing.Point(188, 136);
            this.txt_AlamatPelanggan.Name = "txt_AlamatPelanggan";
            this.txt_AlamatPelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_AlamatPelanggan.TabIndex = 6;
            // 
            // txt_NamaPelanggan
            // 
            this.txt_NamaPelanggan.Location = new System.Drawing.Point(186, 90);
            this.txt_NamaPelanggan.Name = "txt_NamaPelanggan";
            this.txt_NamaPelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_NamaPelanggan.TabIndex = 5;
            // 
            // txt_IdPelanggan
            // 
            this.txt_IdPelanggan.Location = new System.Drawing.Point(186, 56);
            this.txt_IdPelanggan.Name = "txt_IdPelanggan";
            this.txt_IdPelanggan.ReadOnly = true;
            this.txt_IdPelanggan.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPelanggan.TabIndex = 4;
            // 
            // lblNoTelp
            // 
            this.lblNoTelp.AutoSize = true;
            this.lblNoTelp.Location = new System.Drawing.Point(21, 182);
            this.lblNoTelp.Name = "lblNoTelp";
            this.lblNoTelp.Size = new System.Drawing.Size(53, 13);
            this.lblNoTelp.TabIndex = 3;
            this.lblNoTelp.Text = "NO TELP";
            // 
            // lblAlamatPelanggan
            // 
            this.lblAlamatPelanggan.AutoSize = true;
            this.lblAlamatPelanggan.Location = new System.Drawing.Point(21, 136);
            this.lblAlamatPelanggan.Name = "lblAlamatPelanggan";
            this.lblAlamatPelanggan.Size = new System.Drawing.Size(119, 13);
            this.lblAlamatPelanggan.TabIndex = 2;
            this.lblAlamatPelanggan.Text = "ALAMAT PELANGGAN";
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(21, 98);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(107, 13);
            this.lblNamaPelanggan.TabIndex = 1;
            this.lblNamaPelanggan.Text = "NAMA PELANGGAN";
            // 
            // lblIdPelanggan
            // 
            this.lblIdPelanggan.AutoSize = true;
            this.lblIdPelanggan.Location = new System.Drawing.Point(21, 59);
            this.lblIdPelanggan.Name = "lblIdPelanggan";
            this.lblIdPelanggan.Size = new System.Drawing.Size(87, 13);
            this.lblIdPelanggan.TabIndex = 0;
            this.lblIdPelanggan.Text = "ID PELANGGAN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_DisplayPelanggan);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampilan Data";
            // 
            // dg_DisplayPelanggan
            // 
            this.dg_DisplayPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DisplayPelanggan.Location = new System.Drawing.Point(16, 19);
            this.dg_DisplayPelanggan.Name = "dg_DisplayPelanggan";
            this.dg_DisplayPelanggan.Size = new System.Drawing.Size(355, 372);
            this.dg_DisplayPelanggan.TabIndex = 0;
            this.dg_DisplayPelanggan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DisplayPelanggan_CellClick);
            // 
            // PelangganUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 444);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PelangganUI";
            this.Text = "Pengelolaan Pelanggan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayPelanggan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblIdPelanggan;
        private System.Windows.Forms.Label lblAlamatPelanggan;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Button btn_DeletePelanggan;
        private System.Windows.Forms.Button btn_EditPelanggan;
        private System.Windows.Forms.Button btn_AddPelanggan;
        private System.Windows.Forms.TextBox txt_NoTelpPelanggan;
        private System.Windows.Forms.TextBox txt_AlamatPelanggan;
        private System.Windows.Forms.TextBox txt_NamaPelanggan;
        private System.Windows.Forms.TextBox txt_IdPelanggan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_DisplayPelanggan;
        private System.Windows.Forms.Button btn_PulihkanData;
        private System.Windows.Forms.Button btn_HapusPermanen;
    }
}