﻿namespace PhanMenBanMayTinh
{
    partial class Faccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.BTN_changePass = new System.Windows.Forms.Button();
            this.BTN_LogOut = new System.Windows.Forms.Button();
            this.BTN_ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information Account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_account);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 216);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dgv_account
            // 
            this.dgv_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(17, 53);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.Size = new System.Drawing.Size(379, 148);
            this.dgv_account.TabIndex = 2;
            this.dgv_account.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellContentClick);
            // 
            // BTN_changePass
            // 
            this.BTN_changePass.Location = new System.Drawing.Point(190, 246);
            this.BTN_changePass.Name = "BTN_changePass";
            this.BTN_changePass.Size = new System.Drawing.Size(79, 36);
            this.BTN_changePass.TabIndex = 2;
            this.BTN_changePass.Text = "Đổi mật khẩu";
            this.BTN_changePass.UseVisualStyleBackColor = true;
            this.BTN_changePass.Click += new System.EventHandler(this.BTN_changePass_Click);
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Location = new System.Drawing.Point(360, 246);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(75, 36);
            this.BTN_LogOut.TabIndex = 3;
            this.BTN_LogOut.Text = "Đăng xuất";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            this.BTN_LogOut.Click += new System.EventHandler(this.BTN_LogOut_Click);
            // 
            // BTN_
            // 
            this.BTN_.Location = new System.Drawing.Point(39, 246);
            this.BTN_.Name = "BTN_";
            this.BTN_.Size = new System.Drawing.Size(75, 36);
            this.BTN_.TabIndex = 4;
            this.BTN_.Text = "Chốt ca";
            this.BTN_.UseVisualStyleBackColor = true;
            this.BTN_.Click += new System.EventHandler(this.BTN__Click);
            // 
            // Faccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.BTN_);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.BTN_changePass);
            this.Controls.Add(this.panel1);
            this.Name = "Faccount";
            this.Text = "Faccount";
            this.Load += new System.EventHandler(this.Faccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Button BTN_changePass;
        private System.Windows.Forms.Button BTN_LogOut;
        private System.Windows.Forms.Button BTN_;
    }
}