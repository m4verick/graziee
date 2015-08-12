namespace GrazieeProject.View
{
    partial class UserSistemUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_IdPenggunaSistem = new System.Windows.Forms.TextBox();
            this.txt_NamaPengguna = new System.Windows.Forms.TextBox();
            this.txt_KataSandi = new System.Windows.Forms.TextBox();
            this.txt_UlangiKataSandi = new System.Windows.Forms.TextBox();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.btn_AddUserSistem = new System.Windows.Forms.Button();
            this.btn_EditUserSistem = new System.Windows.Forms.Button();
            this.btn_DeleteUserSistem = new System.Windows.Forms.Button();
            this.btn_DeletePermanenUserSistem = new System.Windows.Forms.Button();
            this.btn_RestoreUserSistem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_DisplayUserSistem = new System.Windows.Forms.DataGridView();
            this.txt_IdPenggunaSistemNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayUserSistem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PENGGUNA SISTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAMA PENGGUNA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KATA SANDI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ULANGI KATA SANDI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ROLE";
            // 
            // txt_IdPenggunaSistem
            // 
            this.txt_IdPenggunaSistem.Location = new System.Drawing.Point(167, 30);
            this.txt_IdPenggunaSistem.Name = "txt_IdPenggunaSistem";
            this.txt_IdPenggunaSistem.ReadOnly = true;
            this.txt_IdPenggunaSistem.Size = new System.Drawing.Size(49, 20);
            this.txt_IdPenggunaSistem.TabIndex = 5;
            this.txt_IdPenggunaSistem.Text = "USER-";
            // 
            // txt_NamaPengguna
            // 
            this.txt_NamaPengguna.Location = new System.Drawing.Point(167, 64);
            this.txt_NamaPengguna.Name = "txt_NamaPengguna";
            this.txt_NamaPengguna.Size = new System.Drawing.Size(121, 20);
            this.txt_NamaPengguna.TabIndex = 6;
            // 
            // txt_KataSandi
            // 
            this.txt_KataSandi.Location = new System.Drawing.Point(167, 90);
            this.txt_KataSandi.Name = "txt_KataSandi";
            this.txt_KataSandi.PasswordChar = '*';
            this.txt_KataSandi.Size = new System.Drawing.Size(121, 20);
            this.txt_KataSandi.TabIndex = 7;
            // 
            // txt_UlangiKataSandi
            // 
            this.txt_UlangiKataSandi.Location = new System.Drawing.Point(167, 130);
            this.txt_UlangiKataSandi.Name = "txt_UlangiKataSandi";
            this.txt_UlangiKataSandi.PasswordChar = '*';
            this.txt_UlangiKataSandi.Size = new System.Drawing.Size(121, 20);
            this.txt_UlangiKataSandi.TabIndex = 8;
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(167, 170);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(121, 21);
            this.cmb_Role.TabIndex = 9;
            // 
            // btn_AddUserSistem
            // 
            this.btn_AddUserSistem.Location = new System.Drawing.Point(23, 235);
            this.btn_AddUserSistem.Name = "btn_AddUserSistem";
            this.btn_AddUserSistem.Size = new System.Drawing.Size(89, 23);
            this.btn_AddUserSistem.TabIndex = 10;
            this.btn_AddUserSistem.Text = "Tambah Data";
            this.btn_AddUserSistem.UseVisualStyleBackColor = true;
            this.btn_AddUserSistem.Click += new System.EventHandler(this.btn_AddUserSistem_Click);
            // 
            // btn_EditUserSistem
            // 
            this.btn_EditUserSistem.Location = new System.Drawing.Point(127, 235);
            this.btn_EditUserSistem.Name = "btn_EditUserSistem";
            this.btn_EditUserSistem.Size = new System.Drawing.Size(89, 23);
            this.btn_EditUserSistem.TabIndex = 11;
            this.btn_EditUserSistem.Text = "Ubah Data";
            this.btn_EditUserSistem.UseVisualStyleBackColor = true;
            this.btn_EditUserSistem.Click += new System.EventHandler(this.btn_EditUserSistem_Click);
            // 
            // btn_DeleteUserSistem
            // 
            this.btn_DeleteUserSistem.Location = new System.Drawing.Point(222, 235);
            this.btn_DeleteUserSistem.Name = "btn_DeleteUserSistem";
            this.btn_DeleteUserSistem.Size = new System.Drawing.Size(89, 23);
            this.btn_DeleteUserSistem.TabIndex = 12;
            this.btn_DeleteUserSistem.Text = "Hapus Data";
            this.btn_DeleteUserSistem.UseVisualStyleBackColor = true;
            this.btn_DeleteUserSistem.Click += new System.EventHandler(this.btn_DeleteUserSistem_Click);
            // 
            // btn_DeletePermanenUserSistem
            // 
            this.btn_DeletePermanenUserSistem.Location = new System.Drawing.Point(45, 274);
            this.btn_DeletePermanenUserSistem.Name = "btn_DeletePermanenUserSistem";
            this.btn_DeletePermanenUserSistem.Size = new System.Drawing.Size(100, 23);
            this.btn_DeletePermanenUserSistem.TabIndex = 13;
            this.btn_DeletePermanenUserSistem.Text = "Hapus Permanen";
            this.btn_DeletePermanenUserSistem.UseVisualStyleBackColor = true;
            this.btn_DeletePermanenUserSistem.Click += new System.EventHandler(this.btn_DeletePermanenUserSistem_Click);
            // 
            // btn_RestoreUserSistem
            // 
            this.btn_RestoreUserSistem.Location = new System.Drawing.Point(167, 274);
            this.btn_RestoreUserSistem.Name = "btn_RestoreUserSistem";
            this.btn_RestoreUserSistem.Size = new System.Drawing.Size(100, 23);
            this.btn_RestoreUserSistem.TabIndex = 14;
            this.btn_RestoreUserSistem.Text = "Pulihkan Data";
            this.btn_RestoreUserSistem.UseVisualStyleBackColor = true;
            this.btn_RestoreUserSistem.Click += new System.EventHandler(this.btn_RestoreUserSistem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_IdPenggunaSistemNum);
            this.groupBox1.Controls.Add(this.btn_RestoreUserSistem);
            this.groupBox1.Controls.Add(this.btn_DeletePermanenUserSistem);
            this.groupBox1.Controls.Add(this.btn_DeleteUserSistem);
            this.groupBox1.Controls.Add(this.btn_EditUserSistem);
            this.groupBox1.Controls.Add(this.btn_AddUserSistem);
            this.groupBox1.Controls.Add(this.cmb_Role);
            this.groupBox1.Controls.Add(this.txt_UlangiKataSandi);
            this.groupBox1.Controls.Add(this.txt_KataSandi);
            this.groupBox1.Controls.Add(this.txt_NamaPengguna);
            this.groupBox1.Controls.Add(this.txt_IdPenggunaSistem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 315);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_DisplayUserSistem);
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 420);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tampilan Data";
            // 
            // dg_DisplayUserSistem
            // 
            this.dg_DisplayUserSistem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DisplayUserSistem.Location = new System.Drawing.Point(35, 19);
            this.dg_DisplayUserSistem.Name = "dg_DisplayUserSistem";
            this.dg_DisplayUserSistem.Size = new System.Drawing.Size(355, 372);
            this.dg_DisplayUserSistem.TabIndex = 0;
            // 
            // txt_IdPenggunaSistemNum
            // 
            this.txt_IdPenggunaSistemNum.Location = new System.Drawing.Point(222, 30);
            this.txt_IdPenggunaSistemNum.Name = "txt_IdPenggunaSistemNum";
            this.txt_IdPenggunaSistemNum.ReadOnly = true;
            this.txt_IdPenggunaSistemNum.Size = new System.Drawing.Size(66, 20);
            this.txt_IdPenggunaSistemNum.TabIndex = 15;
            // 
            // UserSistemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 426);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserSistemUI";
            this.Text = "Pengelolaan Pengguna Sistem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DisplayUserSistem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_IdPenggunaSistem;
        private System.Windows.Forms.TextBox txt_NamaPengguna;
        private System.Windows.Forms.TextBox txt_KataSandi;
        private System.Windows.Forms.TextBox txt_UlangiKataSandi;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.Button btn_AddUserSistem;
        private System.Windows.Forms.Button btn_EditUserSistem;
        private System.Windows.Forms.Button btn_DeleteUserSistem;
        private System.Windows.Forms.Button btn_DeletePermanenUserSistem;
        private System.Windows.Forms.Button btn_RestoreUserSistem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_DisplayUserSistem;
        private System.Windows.Forms.TextBox txt_IdPenggunaSistemNum;


    }
}