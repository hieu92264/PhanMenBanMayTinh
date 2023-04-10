namespace PhanMenBanMayTinh
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
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Reset = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
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
            // 
            // dgv_account
            // 
            this.dgv_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(18, 56);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.ReadOnly = true;
            this.dgv_account.Size = new System.Drawing.Size(379, 148);
            this.dgv_account.TabIndex = 2;
            // 
            // BTN_changePass
            // 
            this.BTN_changePass.Location = new System.Drawing.Point(356, 251);
            this.BTN_changePass.Name = "BTN_changePass";
            this.BTN_changePass.Size = new System.Drawing.Size(79, 36);
            this.BTN_changePass.TabIndex = 2;
            this.BTN_changePass.Text = "Đổi mật khẩu";
            this.BTN_changePass.UseVisualStyleBackColor = true;
            this.BTN_changePass.Click += new System.EventHandler(this.BTN_changePass_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(22, 251);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 36);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Thêm";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Reset
            // 
            this.BTN_Reset.Location = new System.Drawing.Point(130, 251);
            this.BTN_Reset.Name = "BTN_Reset";
            this.BTN_Reset.Size = new System.Drawing.Size(75, 36);
            this.BTN_Reset.TabIndex = 4;
            this.BTN_Reset.Text = "Sửa";
            this.BTN_Reset.UseVisualStyleBackColor = true;
            // 
            // BTN_Del
            // 
            this.BTN_Del.Location = new System.Drawing.Point(235, 251);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(75, 36);
            this.BTN_Del.TabIndex = 5;
            this.BTN_Del.Text = "Xoá";
            this.BTN_Del.UseVisualStyleBackColor = true;
            // 
            // Faccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 316);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.BTN_Reset);
            this.Controls.Add(this.BTN_changePass);
            this.Controls.Add(this.BTN_Add);
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
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Del;
    }
}