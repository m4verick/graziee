namespace GrazieeProject.View
{
    partial class WarnaBarangUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdWarnaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NamaWarna = new System.Windows.Forms.TextBox();
            this.btn_TambahWarnaBarang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TambahWarnaBarang);
            this.groupBox1.Controls.Add(this.txt_NamaWarna);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_IdWarnaBarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID WARNA BARANG";
            // 
            // txt_IdWarnaBarang
            // 
            this.txt_IdWarnaBarang.Location = new System.Drawing.Point(170, 42);
            this.txt_IdWarnaBarang.Name = "txt_IdWarnaBarang";
            this.txt_IdWarnaBarang.ReadOnly = true;
            this.txt_IdWarnaBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_IdWarnaBarang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAMA WARNA BARANG";
            // 
            // txt_NamaWarna
            // 
            this.txt_NamaWarna.Location = new System.Drawing.Point(170, 78);
            this.txt_NamaWarna.Name = "txt_NamaWarna";
            this.txt_NamaWarna.Size = new System.Drawing.Size(100, 20);
            this.txt_NamaWarna.TabIndex = 3;
            // 
            // btn_TambahWarnaBarang
            // 
            this.btn_TambahWarnaBarang.Location = new System.Drawing.Point(137, 118);
            this.btn_TambahWarnaBarang.Name = "btn_TambahWarnaBarang";
            this.btn_TambahWarnaBarang.Size = new System.Drawing.Size(90, 23);
            this.btn_TambahWarnaBarang.TabIndex = 4;
            this.btn_TambahWarnaBarang.Text = "Tambah Data";
            this.btn_TambahWarnaBarang.UseVisualStyleBackColor = true;
            this.btn_TambahWarnaBarang.Click += new System.EventHandler(this.btn_TambahWarnaBarang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Data";
            // 
            // WarnaBarangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "WarnaBarangUI";
            this.Text = "Warna Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdWarnaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_TambahWarnaBarang;
        private System.Windows.Forms.TextBox txt_NamaWarna;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}