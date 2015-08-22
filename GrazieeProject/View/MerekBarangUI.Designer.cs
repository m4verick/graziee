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
            this.txt_NamaMerekBarang = new System.Windows.Forms.TextBox();
            this.txt_IdMerekBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddMerekBarang = new System.Windows.Forms.Button();
            this.txt_IdMerekBarangNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_IdModelBarangNum = new System.Windows.Forms.TextBox();
            this.txt_NamaModelBarang = new System.Windows.Forms.TextBox();
            this.txt_IdModelBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddModelBarang = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IdWarnaBarangNum = new System.Windows.Forms.TextBox();
            this.txt_NamaWarnaBarang = new System.Windows.Forms.TextBox();
            this.txt_IdWarnaBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_AddWarnaBarang = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgv_MerekBarang = new System.Windows.Forms.DataGridView();
            this.dgv_ModelBarang = new System.Windows.Forms.DataGridView();
            this.dgv_WarnaBarang = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MerekBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelBarang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WarnaBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_IdMerekBarangNum);
            this.groupBox1.Controls.Add(this.txt_NamaMerekBarang);
            this.groupBox1.Controls.Add(this.txt_IdMerekBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_AddMerekBarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Merek Barang";
            // 
            // txt_NamaMerekBarang
            // 
            this.txt_NamaMerekBarang.Location = new System.Drawing.Point(122, 72);
            this.txt_NamaMerekBarang.Name = "txt_NamaMerekBarang";
            this.txt_NamaMerekBarang.Size = new System.Drawing.Size(162, 20);
            this.txt_NamaMerekBarang.TabIndex = 4;
            // 
            // txt_IdMerekBarang
            // 
            this.txt_IdMerekBarang.Location = new System.Drawing.Point(122, 35);
            this.txt_IdMerekBarang.Name = "txt_IdMerekBarang";
            this.txt_IdMerekBarang.ReadOnly = true;
            this.txt_IdMerekBarang.Size = new System.Drawing.Size(56, 20);
            this.txt_IdMerekBarang.TabIndex = 3;
            this.txt_IdMerekBarang.Text = "MRK-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAMA MEREK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID MEREK";
            // 
            // btn_AddMerekBarang
            // 
            this.btn_AddMerekBarang.Location = new System.Drawing.Point(122, 112);
            this.btn_AddMerekBarang.Name = "btn_AddMerekBarang";
            this.btn_AddMerekBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddMerekBarang.TabIndex = 0;
            this.btn_AddMerekBarang.Text = "Tambah Data";
            this.btn_AddMerekBarang.UseVisualStyleBackColor = true;
            this.btn_AddMerekBarang.Click += new System.EventHandler(this.btn_AddMerekBarang_Click);
            // 
            // txt_IdMerekBarangNum
            // 
            this.txt_IdMerekBarangNum.Location = new System.Drawing.Point(184, 35);
            this.txt_IdMerekBarangNum.Name = "txt_IdMerekBarangNum";
            this.txt_IdMerekBarangNum.ReadOnly = true;
            this.txt_IdMerekBarangNum.Size = new System.Drawing.Size(100, 20);
            this.txt_IdMerekBarangNum.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_IdModelBarangNum);
            this.groupBox2.Controls.Add(this.txt_NamaModelBarang);
            this.groupBox2.Controls.Add(this.txt_IdModelBarang);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btn_AddModelBarang);
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 162);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Model Barang";
            // 
            // txt_IdModelBarangNum
            // 
            this.txt_IdModelBarangNum.Location = new System.Drawing.Point(184, 35);
            this.txt_IdModelBarangNum.Name = "txt_IdModelBarangNum";
            this.txt_IdModelBarangNum.ReadOnly = true;
            this.txt_IdModelBarangNum.Size = new System.Drawing.Size(100, 20);
            this.txt_IdModelBarangNum.TabIndex = 5;
            // 
            // txt_NamaModelBarang
            // 
            this.txt_NamaModelBarang.Location = new System.Drawing.Point(122, 72);
            this.txt_NamaModelBarang.Name = "txt_NamaModelBarang";
            this.txt_NamaModelBarang.Size = new System.Drawing.Size(162, 20);
            this.txt_NamaModelBarang.TabIndex = 4;
            // 
            // txt_IdModelBarang
            // 
            this.txt_IdModelBarang.Location = new System.Drawing.Point(122, 35);
            this.txt_IdModelBarang.Name = "txt_IdModelBarang";
            this.txt_IdModelBarang.ReadOnly = true;
            this.txt_IdModelBarang.Size = new System.Drawing.Size(56, 20);
            this.txt_IdModelBarang.TabIndex = 3;
            this.txt_IdModelBarang.Text = "MDL-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAMA MODEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "ID MODEL";
            // 
            // btn_AddModelBarang
            // 
            this.btn_AddModelBarang.Location = new System.Drawing.Point(122, 112);
            this.btn_AddModelBarang.Name = "btn_AddModelBarang";
            this.btn_AddModelBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddModelBarang.TabIndex = 0;
            this.btn_AddModelBarang.Text = "Tambah Data";
            this.btn_AddModelBarang.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_IdWarnaBarangNum);
            this.groupBox3.Controls.Add(this.txt_NamaWarnaBarang);
            this.groupBox3.Controls.Add(this.txt_IdWarnaBarang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btn_AddWarnaBarang);
            this.groupBox3.Location = new System.Drawing.Point(652, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 162);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Warna Barang";
            // 
            // txt_IdWarnaBarangNum
            // 
            this.txt_IdWarnaBarangNum.Location = new System.Drawing.Point(184, 35);
            this.txt_IdWarnaBarangNum.Name = "txt_IdWarnaBarangNum";
            this.txt_IdWarnaBarangNum.ReadOnly = true;
            this.txt_IdWarnaBarangNum.Size = new System.Drawing.Size(100, 20);
            this.txt_IdWarnaBarangNum.TabIndex = 5;
            // 
            // txt_NamaWarnaBarang
            // 
            this.txt_NamaWarnaBarang.Location = new System.Drawing.Point(122, 72);
            this.txt_NamaWarnaBarang.Name = "txt_NamaWarnaBarang";
            this.txt_NamaWarnaBarang.Size = new System.Drawing.Size(162, 20);
            this.txt_NamaWarnaBarang.TabIndex = 4;
            // 
            // txt_IdWarnaBarang
            // 
            this.txt_IdWarnaBarang.Location = new System.Drawing.Point(122, 35);
            this.txt_IdWarnaBarang.Name = "txt_IdWarnaBarang";
            this.txt_IdWarnaBarang.ReadOnly = true;
            this.txt_IdWarnaBarang.Size = new System.Drawing.Size(56, 20);
            this.txt_IdWarnaBarang.TabIndex = 3;
            this.txt_IdWarnaBarang.Text = "WRN-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "NAMA WARNA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID WARNA";
            // 
            // btn_AddWarnaBarang
            // 
            this.btn_AddWarnaBarang.Location = new System.Drawing.Point(122, 112);
            this.btn_AddWarnaBarang.Name = "btn_AddWarnaBarang";
            this.btn_AddWarnaBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddWarnaBarang.TabIndex = 0;
            this.btn_AddWarnaBarang.Text = "Tambah Data";
            this.btn_AddWarnaBarang.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_MerekBarang);
            this.groupBox4.Location = new System.Drawing.Point(12, 180);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 423);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Display Merek Barang";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_ModelBarang);
            this.groupBox5.Location = new System.Drawing.Point(332, 180);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(314, 423);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Display Model Barang";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgv_WarnaBarang);
            this.groupBox6.Location = new System.Drawing.Point(652, 180);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(314, 423);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Display Warna Barang";
            // 
            // dgv_MerekBarang
            // 
            this.dgv_MerekBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MerekBarang.Location = new System.Drawing.Point(6, 59);
            this.dgv_MerekBarang.Name = "dgv_MerekBarang";
            this.dgv_MerekBarang.Size = new System.Drawing.Size(302, 358);
            this.dgv_MerekBarang.TabIndex = 0;
            // 
            // dgv_ModelBarang
            // 
            this.dgv_ModelBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModelBarang.Location = new System.Drawing.Point(6, 57);
            this.dgv_ModelBarang.Name = "dgv_ModelBarang";
            this.dgv_ModelBarang.Size = new System.Drawing.Size(302, 358);
            this.dgv_ModelBarang.TabIndex = 1;
            // 
            // dgv_WarnaBarang
            // 
            this.dgv_WarnaBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_WarnaBarang.Location = new System.Drawing.Point(6, 56);
            this.dgv_WarnaBarang.Name = "dgv_WarnaBarang";
            this.dgv_WarnaBarang.Size = new System.Drawing.Size(302, 358);
            this.dgv_WarnaBarang.TabIndex = 1;
            // 
            // MerekBarangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 615);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MerekBarangUI";
            this.Text = "Model - Merek - Warna";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MerekBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModelBarang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_WarnaBarang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddMerekBarang;
        private System.Windows.Forms.TextBox txt_NamaMerekBarang;
        private System.Windows.Forms.TextBox txt_IdMerekBarang;
        private System.Windows.Forms.TextBox txt_IdMerekBarangNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_IdModelBarangNum;
        private System.Windows.Forms.TextBox txt_NamaModelBarang;
        private System.Windows.Forms.TextBox txt_IdModelBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddModelBarang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_IdWarnaBarangNum;
        private System.Windows.Forms.TextBox txt_NamaWarnaBarang;
        private System.Windows.Forms.TextBox txt_IdWarnaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_AddWarnaBarang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgv_MerekBarang;
        private System.Windows.Forms.DataGridView dgv_ModelBarang;
        private System.Windows.Forms.DataGridView dgv_WarnaBarang;
    }
}