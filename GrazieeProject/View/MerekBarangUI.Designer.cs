namespace GrazieeProject.View
{
    partial class MerekBarangUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddMerekBarang = new System.Windows.Forms.Button();
            this.txt_IdMerekBarang = new System.Windows.Forms.TextBox();
            this.txt_NamaMerekBarang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_NamaMerekBarang);
            this.groupBox1.Controls.Add(this.txt_IdMerekBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_AddMerekBarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAMA MEREK BARANG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID MEREK BARANG";
            // 
            // btn_AddMerekBarang
            // 
            this.btn_AddMerekBarang.Location = new System.Drawing.Point(145, 144);
            this.btn_AddMerekBarang.Name = "btn_AddMerekBarang";
            this.btn_AddMerekBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddMerekBarang.TabIndex = 0;
            this.btn_AddMerekBarang.Text = "Tambah Data";
            this.btn_AddMerekBarang.UseVisualStyleBackColor = true;
            this.btn_AddMerekBarang.Click += new System.EventHandler(this.btn_AddMerekBarang_Click);
            // 
            // txt_IdMerekBarang
            // 
            this.txt_IdMerekBarang.Location = new System.Drawing.Point(188, 35);
            this.txt_IdMerekBarang.Name = "txt_IdMerekBarang";
            this.txt_IdMerekBarang.ReadOnly = true;
            this.txt_IdMerekBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_IdMerekBarang.TabIndex = 3;
            // 
            // txt_NamaMerekBarang
            // 
            this.txt_NamaMerekBarang.Location = new System.Drawing.Point(188, 72);
            this.txt_NamaMerekBarang.Name = "txt_NamaMerekBarang";
            this.txt_NamaMerekBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_NamaMerekBarang.TabIndex = 4;
            // 
            // MerekBarangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 262);
            this.Controls.Add(this.groupBox1);
            this.Name = "MerekBarangUI";
            this.Text = "Merek Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddMerekBarang;
        private System.Windows.Forms.TextBox txt_NamaMerekBarang;
        private System.Windows.Forms.TextBox txt_IdMerekBarang;
    }
}