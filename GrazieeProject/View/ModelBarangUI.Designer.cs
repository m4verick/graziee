namespace GrazieeProject.View
{
    partial class ModelBarangUI
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
            this.txt_IdModelBarang = new System.Windows.Forms.TextBox();
            this.txt_NamaModelBarang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddModelBarang = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddModelBarang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_NamaModelBarang);
            this.groupBox1.Controls.Add(this.txt_IdModelBarang);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // txt_IdModelBarang
            // 
            this.txt_IdModelBarang.Location = new System.Drawing.Point(137, 41);
            this.txt_IdModelBarang.Name = "txt_IdModelBarang";
            this.txt_IdModelBarang.ReadOnly = true;
            this.txt_IdModelBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_IdModelBarang.TabIndex = 0;
            // 
            // txt_NamaModelBarang
            // 
            this.txt_NamaModelBarang.Location = new System.Drawing.Point(149, 97);
            this.txt_NamaModelBarang.Name = "txt_NamaModelBarang";
            this.txt_NamaModelBarang.Size = new System.Drawing.Size(100, 20);
            this.txt_NamaModelBarang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID MODEL BARANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NAMA MODEL BARANG";
            // 
            // btn_AddModelBarang
            // 
            this.btn_AddModelBarang.Location = new System.Drawing.Point(57, 177);
            this.btn_AddModelBarang.Name = "btn_AddModelBarang";
            this.btn_AddModelBarang.Size = new System.Drawing.Size(75, 23);
            this.btn_AddModelBarang.TabIndex = 4;
            this.btn_AddModelBarang.Text = "Tambah Data";
            this.btn_AddModelBarang.UseVisualStyleBackColor = true;
            this.btn_AddModelBarang.Click += new System.EventHandler(this.btn_AddModelBarang_Click);
            // 
            // ModelBarangUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 329);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModelBarangUI";
            this.Text = "Model Barang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddModelBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NamaModelBarang;
        private System.Windows.Forms.TextBox txt_IdModelBarang;
    }
}