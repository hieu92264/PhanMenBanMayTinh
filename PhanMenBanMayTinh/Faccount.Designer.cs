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
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 254);
            this.panel1.TabIndex = 1;
            // 
            // dgv_account
            // 
            this.dgv_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(17, 53);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.Size = new System.Drawing.Size(170, 186);
            this.dgv_account.TabIndex = 2;
            // 
            // BTN_changePass
            // 
            this.BTN_changePass.Location = new System.Drawing.Point(185, 327);
            this.BTN_changePass.Name = "BTN_changePass";
            this.BTN_changePass.Size = new System.Drawing.Size(79, 23);
            this.BTN_changePass.TabIndex = 2;
            this.BTN_changePass.Text = "Đổi mật khẩu";
            this.BTN_changePass.UseVisualStyleBackColor = true;
            // 
            // BTN_LogOut
            // 
            this.BTN_LogOut.Location = new System.Drawing.Point(350, 327);
            this.BTN_LogOut.Name = "BTN_LogOut";
            this.BTN_LogOut.Size = new System.Drawing.Size(75, 23);
            this.BTN_LogOut.TabIndex = 3;
            this.BTN_LogOut.Text = "Đăng xuất";
            this.BTN_LogOut.UseVisualStyleBackColor = true;
            // 
            // BTN_
            // 
            this.BTN_.Location = new System.Drawing.Point(29, 327);
            this.BTN_.Name = "BTN_";
            this.BTN_.Size = new System.Drawing.Size(75, 23);
            this.BTN_.TabIndex = 4;
            this.BTN_.Text = "Chốt ca";
            this.BTN_.UseVisualStyleBackColor = true;
            // 
            // Faccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 396);
            this.Controls.Add(this.BTN_);
            this.Controls.Add(this.BTN_LogOut);
            this.Controls.Add(this.BTN_changePass);
            this.Controls.Add(this.panel1);
            this.Name = "Faccount";
            this.Text = "Faccount";
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