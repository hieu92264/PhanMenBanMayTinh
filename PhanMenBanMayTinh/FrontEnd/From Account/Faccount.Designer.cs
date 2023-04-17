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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DisplayName = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(22, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 224);
            this.panel1.TabIndex = 1;
            // 
            // dgv_account
            // 
            this.dgv_account.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(18, 54);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.ReadOnly = true;
            this.dgv_account.Size = new System.Drawing.Size(379, 148);
            this.dgv_account.TabIndex = 2;
            this.dgv_account.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_account_CellClick);
            this.dgv_account.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_account_RowHeaderMouseClick);
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
            this.BTN_Reset.Click += new System.EventHandler(this.BTN_Reset_Click);
            // 
            // BTN_Del
            // 
            this.BTN_Del.Location = new System.Drawing.Point(235, 251);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(75, 36);
            this.BTN_Del.TabIndex = 5;
            this.BTN_Del.Text = "Xoá";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(439, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "UserName:";
            // 
            // txt_DisplayName
            // 
            this.txt_DisplayName.Location = new System.Drawing.Point(516, 97);
            this.txt_DisplayName.Name = "txt_DisplayName";
            this.txt_DisplayName.Size = new System.Drawing.Size(164, 20);
            this.txt_DisplayName.TabIndex = 8;
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(515, 132);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(114, 20);
            this.txt_type.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Id:";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(516, 58);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(114, 20);
            this.txt_Id.TabIndex = 12;
            // 
            // Faccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 316);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.txt_DisplayName);
            this.Controls.Add(this.label3);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.Button BTN_changePass;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Reset;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DisplayName;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id;
    }
}