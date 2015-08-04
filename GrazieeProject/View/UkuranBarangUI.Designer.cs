namespace GrazieeProject.View
{
    partial class UkuranBarangUI
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
            this.txt_IdUkuran = new System.Windows.Forms.TextBox();
            this.txt_NamaUkuran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddUkuranBarang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddUkuranBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NamaUkuran);
            this.groupBox1.Controls.Add(this.txt_IdUkuran);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txt_IdUkuran
            // 
            this.txt_IdUkuran.Location = new System.Drawing.Point(204, 36);
            this.txt_IdUkuran.Name = "txt_IdUkuran";
            this.txt_IdUkuran.ReadOnly = true;
            this.txt_IdUkuran.Size = new System.Drawing.Size(100, 20);
            this.txt_IdUkuran.TabIndex = 0;
            // 
            // txt_NamaUkuran
            // 
            this.txt_NamaUkuran.Location = new System.Drawing.Point(204, 84);
            this.txt_NamaUkuran.Name = "txt_NamaUkuran";
            this.txt_NamaUkuran.Size = new System.Drawing.Size(100, 20);
            this.txt_NamaUkuran.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID UKURAN BARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAMA UKURAN";
            // 
            // btn_AddUkuranBarang
            // 
            this.btn_AddUkuranBarang.Location = new System.Drawing.Point(151, 137);
            this.btn_AddUkuranBarang.Name = "btn_AddUkuranBarang";
            this.btn_AddUkuranBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddUkuranBarang.TabIndex = 4;
            this.btn_AddUkuranBarang.Text = "Tambah Data";
            this.btn_AddUkuranBarang.UseVisualStyleBackColor = true;
            this.btn_AddUkuranBarang.Click += new System.EventHandler(this.btn_AddUkuranBarang_Click);
            // 
            // UkuranBarangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "UkuranBarangUI";
            this.Text = "Ukuran Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NamaUkuran;
        private System.Windows.Forms.TextBox txt_IdUkuran;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddUkuranBarang;
    }
}