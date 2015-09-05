namespace GrazieeProject.View
{
    partial class SupplierUI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_DisplaySupplier = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_IdSupplierNum = new System.Windows.Forms.TextBox();
            this.btn_PulihkanData = new System.Windows.Forms.Button();
            this.btn_HapusPermanen = new System.Windows.Forms.Button();
            this.btn_DeleteSupplier = new System.Windows.Forms.Button();
            this.btn_EditSupplier = new System.Windows.Forms.Button();
            this.btn_AddSupplier = new System.Windows.Forms.Button();
            this.txt_NoTelpSupplier = new System.Windows.Forms.TextBox();
            this.txt_AlamatSupplier = new System.Windows.Forms.TextBox();
            this.txt_NamaSupplier = new System.Windows.Forms.TextBox();
            this.txt_IdSupplier = new System.Windows.Forms.TextBox();
            this.lblNoTelp = new System.Windows.Forms.Label();
            this.lblAlamatPelanggan = new System.Windows.Forms.Label();
            this.lblNamaPelanggan = new System.Windows.Forms.Label();
            this.lblIdPelanggan = new System.Windows.Forms.Label();
            this.txt_SearchSuplier = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplaySupplier)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_SearchSuplier);
            this.groupBox2.Controls.Add(this.dg_DisplaySupplier);
            this.groupBox2.Location = new System.Drawing.Point(350, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 420);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Data";
            // 
            // dg_DisplaySupplier
            // 
            this.dg_DisplaySupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DisplaySupplier.Location = new System.Drawing.Point(6, 56);
            this.dg_DisplaySupplier.Name = "dg_DisplaySupplier";
            this.dg_DisplaySupplier.Size = new System.Drawing.Size(384, 358);
            this.dg_DisplaySupplier.TabIndex = 0;
            this.dg_DisplaySupplier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DisplaySupplier_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.txt_IdSupplierNum);
            this.groupBox1.Controls.Add(this.btn_PulihkanData);
            this.groupBox1.Controls.Add(this.btn_HapusPermanen);
            this.groupBox1.Controls.Add(this.btn_DeleteSupplier);
            this.groupBox1.Controls.Add(this.btn_EditSupplier);
            this.groupBox1.Controls.Add(this.btn_AddSupplier);
            this.groupBox1.Controls.Add(this.txt_NoTelpSupplier);
            this.groupBox1.Controls.Add(this.txt_AlamatSupplier);
            this.groupBox1.Controls.Add(this.txt_NamaSupplier);
            this.groupBox1.Controls.Add(this.txt_IdSupplier);
            this.groupBox1.Controls.Add(this.lblNoTelp);
            this.groupBox1.Controls.Add(this.lblAlamatPelanggan);
            this.groupBox1.Controls.Add(this.lblNamaPelanggan);
            this.groupBox1.Controls.Add(this.lblIdPelanggan);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 425);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txt_IdSupplierNum
            // 
            this.txt_IdSupplierNum.Location = new System.Drawing.Point(255, 56);
            this.txt_IdSupplierNum.Name = "txt_IdSupplierNum";
            this.txt_IdSupplierNum.ReadOnly = true;
            this.txt_IdSupplierNum.Size = new System.Drawing.Size(62, 20);
            this.txt_IdSupplierNum.TabIndex = 13;
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
            // btn_DeleteSupplier
            // 
            this.btn_DeleteSupplier.Location = new System.Drawing.Point(242, 274);
            this.btn_DeleteSupplier.Name = "btn_DeleteSupplier";
            this.btn_DeleteSupplier.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteSupplier.TabIndex = 10;
            this.btn_DeleteSupplier.Text = "Hapus Data";
            this.btn_DeleteSupplier.UseVisualStyleBackColor = true;
            this.btn_DeleteSupplier.Click += new System.EventHandler(this.btn_DeleteSupplier_Click);
            // 
            // btn_EditSupplier
            // 
            this.btn_EditSupplier.Location = new System.Drawing.Point(149, 274);
            this.btn_EditSupplier.Name = "btn_EditSupplier";
            this.btn_EditSupplier.Size = new System.Drawing.Size(75, 23);
            this.btn_EditSupplier.TabIndex = 9;
            this.btn_EditSupplier.Text = "Ubah Data";
            this.btn_EditSupplier.UseVisualStyleBackColor = true;
            this.btn_EditSupplier.Click += new System.EventHandler(this.btn_EditSupplier_Click);
            // 
            // btn_AddSupplier
            // 
            this.btn_AddSupplier.Location = new System.Drawing.Point(32, 274);
            this.btn_AddSupplier.Name = "btn_AddSupplier";
            this.btn_AddSupplier.Size = new System.Drawing.Size(95, 23);
            this.btn_AddSupplier.TabIndex = 8;
            this.btn_AddSupplier.Text = "Tambah Data";
            this.btn_AddSupplier.UseVisualStyleBackColor = true;
            this.btn_AddSupplier.Click += new System.EventHandler(this.btn_AddSupplier_Click);
            // 
            // txt_NoTelpSupplier
            // 
            this.txt_NoTelpSupplier.Location = new System.Drawing.Point(179, 182);
            this.txt_NoTelpSupplier.Name = "txt_NoTelpSupplier";
            this.txt_NoTelpSupplier.Size = new System.Drawing.Size(138, 20);
            this.txt_NoTelpSupplier.TabIndex = 7;
            // 
            // txt_AlamatSupplier
            // 
            this.txt_AlamatSupplier.Location = new System.Drawing.Point(179, 136);
            this.txt_AlamatSupplier.Name = "txt_AlamatSupplier";
            this.txt_AlamatSupplier.Size = new System.Drawing.Size(138, 20);
            this.txt_AlamatSupplier.TabIndex = 6;
            // 
            // txt_NamaSupplier
            // 
            this.txt_NamaSupplier.Location = new System.Drawing.Point(179, 90);
            this.txt_NamaSupplier.Name = "txt_NamaSupplier";
            this.txt_NamaSupplier.Size = new System.Drawing.Size(138, 20);
            this.txt_NamaSupplier.TabIndex = 5;
            // 
            // txt_IdSupplier
            // 
            this.txt_IdSupplier.Location = new System.Drawing.Point(179, 56);
            this.txt_IdSupplier.Name = "txt_IdSupplier";
            this.txt_IdSupplier.ReadOnly = true;
            this.txt_IdSupplier.Size = new System.Drawing.Size(70, 20);
            this.txt_IdSupplier.TabIndex = 4;
            this.txt_IdSupplier.Text = "SUP-";
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
            this.lblAlamatPelanggan.Size = new System.Drawing.Size(106, 13);
            this.lblAlamatPelanggan.TabIndex = 2;
            this.lblAlamatPelanggan.Text = "ALAMAT SUPPLIER";
            // 
            // lblNamaPelanggan
            // 
            this.lblNamaPelanggan.AutoSize = true;
            this.lblNamaPelanggan.Location = new System.Drawing.Point(40, 98);
            this.lblNamaPelanggan.Name = "lblNamaPelanggan";
            this.lblNamaPelanggan.Size = new System.Drawing.Size(94, 13);
            this.lblNamaPelanggan.TabIndex = 1;
            this.lblNamaPelanggan.Text = "NAMA SUPPLIER";
            // 
            // lblIdPelanggan
            // 
            this.lblIdPelanggan.AutoSize = true;
            this.lblIdPelanggan.Location = new System.Drawing.Point(40, 59);
            this.lblIdPelanggan.Name = "lblIdPelanggan";
            this.lblIdPelanggan.Size = new System.Drawing.Size(74, 13);
            this.lblIdPelanggan.TabIndex = 0;
            this.lblIdPelanggan.Text = "ID SUPPLIER";
            // 
            // txt_SearchSuplier
            // 
            this.txt_SearchSuplier.Location = new System.Drawing.Point(6, 24);
            this.txt_SearchSuplier.Name = "txt_SearchSuplier";
            this.txt_SearchSuplier.Size = new System.Drawing.Size(150, 20);
            this.txt_SearchSuplier.TabIndex = 1;
            this.txt_SearchSuplier.TextChanged += new System.EventHandler(this.txt_SearchSuplier_TextChanged);
            // 
            // SupplierUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 452);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SupplierUI";
            this.Text = "Pengelolaan Supplier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplaySupplier)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_DisplaySupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_PulihkanData;
        private System.Windows.Forms.Button btn_HapusPermanen;
        private System.Windows.Forms.Button btn_DeleteSupplier;
        private System.Windows.Forms.Button btn_EditSupplier;
        private System.Windows.Forms.Button btn_AddSupplier;
        private System.Windows.Forms.TextBox txt_NoTelpSupplier;
        private System.Windows.Forms.TextBox txt_AlamatSupplier;
        private System.Windows.Forms.TextBox txt_NamaSupplier;
        private System.Windows.Forms.TextBox txt_IdSupplier;
        private System.Windows.Forms.Label lblNoTelp;
        private System.Windows.Forms.Label lblAlamatPelanggan;
        private System.Windows.Forms.Label lblNamaPelanggan;
        private System.Windows.Forms.Label lblIdPelanggan;
        private System.Windows.Forms.TextBox txt_IdSupplierNum;
        private System.Windows.Forms.TextBox txt_SearchSuplier;
    }
}