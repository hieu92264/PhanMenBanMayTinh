namespace PhanMenBanMayTinh
{
    partial class Add_Account
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
            this.textId = new System.Windows.Forms.TextBox();
            this.text_Display_name = new System.Windows.Forms.TextBox();
            this.text_Pass = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(108, 29);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(196, 20);
            this.textId.TabIndex = 1;
            // 
            // text_Display_name
            // 
            this.text_Display_name.Location = new System.Drawing.Point(108, 66);
            this.text_Display_name.Name = "text_Display_name";
            this.text_Display_name.Size = new System.Drawing.Size(196, 20);
            this.text_Display_name.TabIndex = 2;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(108, 103);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.Size = new System.Drawing.Size(196, 20);
            this.text_Pass.TabIndex = 3;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(219, 146);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 4;
            this.BTN_Add.Text = "Thêm";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "DisplayName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.text_Pass);
            this.Controls.Add(this.text_Display_name);
            this.Controls.Add(this.textId);
            this.Name = "Add_Account";
            this.Text = "Add_Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox text_Display_name;
        private System.Windows.Forms.TextBox text_Pass;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}