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
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(36, 44);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 0;
            // 
            // text_Display_name
            // 
            this.text_Display_name.Location = new System.Drawing.Point(205, 44);
            this.text_Display_name.Name = "text_Display_name";
            this.text_Display_name.Size = new System.Drawing.Size(100, 20);
            this.text_Display_name.TabIndex = 1;
            // 
            // text_Pass
            // 
            this.text_Pass.Location = new System.Drawing.Point(369, 44);
            this.text_Pass.Name = "text_Pass";
            this.text_Pass.Size = new System.Drawing.Size(100, 20);
            this.text_Pass.TabIndex = 2;
            // 
            // BTN_Add
            // 
            this.BTN_Add.Location = new System.Drawing.Point(369, 103);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(75, 23);
            this.BTN_Add.TabIndex = 3;
            this.BTN_Add.Text = "Thêm";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // Add_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 153);
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
    }
}