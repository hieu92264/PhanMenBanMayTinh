namespace PhanMenBanMayTinh
{
    partial class ChangePass
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_pass_old = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_repeat_pass = new System.Windows.Forms.TextBox();
            this.text_pass_new = new System.Windows.Forms.TextBox();
            this.BTN_ResetPass = new System.Windows.Forms.Button();
            this.text_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhanMenBanMayTinh.Properties.Resources.icon_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // text_pass_old
            // 
            this.text_pass_old.Location = new System.Drawing.Point(135, 41);
            this.text_pass_old.Name = "text_pass_old";
            this.text_pass_old.PasswordChar = '*';
            this.text_pass_old.Size = new System.Drawing.Size(181, 21);
            this.text_pass_old.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.text_Id);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text_repeat_pass);
            this.panel1.Controls.Add(this.text_pass_new);
            this.panel1.Controls.Add(this.text_pass_old);
            this.panel1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 147);
            this.panel1.TabIndex = 2;
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(135, 10);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(181, 21);
            this.text_Id.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Id Account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // text_repeat_pass
            // 
            this.text_repeat_pass.Location = new System.Drawing.Point(135, 112);
            this.text_repeat_pass.Name = "text_repeat_pass";
            this.text_repeat_pass.PasswordChar = '*';
            this.text_repeat_pass.Size = new System.Drawing.Size(181, 21);
            this.text_repeat_pass.TabIndex = 4;
            // 
            // text_pass_new
            // 
            this.text_pass_new.Location = new System.Drawing.Point(135, 77);
            this.text_pass_new.Name = "text_pass_new";
            this.text_pass_new.PasswordChar = '*';
            this.text_pass_new.Size = new System.Drawing.Size(181, 21);
            this.text_pass_new.TabIndex = 3;
            // 
            // BTN_ResetPass
            // 
            this.BTN_ResetPass.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ResetPass.Location = new System.Drawing.Point(229, 257);
            this.BTN_ResetPass.Name = "BTN_ResetPass";
            this.BTN_ResetPass.Size = new System.Drawing.Size(91, 23);
            this.BTN_ResetPass.TabIndex = 5;
            this.BTN_ResetPass.Text = "Đổi mật khẩu";
            this.BTN_ResetPass.UseVisualStyleBackColor = true;
            this.BTN_ResetPass.Click += new System.EventHandler(this.BTN_ResetPass_Click);
            // 
            // text_result
            // 
            this.text_result.Location = new System.Drawing.Point(59, 257);
            this.text_result.Name = "text_result";
            this.text_result.Size = new System.Drawing.Size(100, 20);
            this.text_result.TabIndex = 6;
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 292);
            this.Controls.Add(this.text_result);
            this.Controls.Add(this.BTN_ResetPass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(368, 331);
            this.MinimumSize = new System.Drawing.Size(368, 331);
            this.Name = "ChangePass";
            this.Text = "ChangePass";
            this.Load += new System.EventHandler(this.ChangePass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_pass_old;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_repeat_pass;
        private System.Windows.Forms.TextBox text_pass_new;
        private System.Windows.Forms.Button BTN_ResetPass;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_result;
    }
}