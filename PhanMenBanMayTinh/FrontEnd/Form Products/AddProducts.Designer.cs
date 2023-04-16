namespace PhanMenBanMayTinh.FrontEnd.Form_Products
{
    partial class AddProducts
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
            this.Product_Name = new System.Windows.Forms.Label();
            this.IdProducts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.BTN_Insert = new System.Windows.Forms.Button();
            this.StreamImg = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Update = new System.Windows.Forms.Button();
            this.BTN_Exit = new System.Windows.Forms.Button();
            this.BTN_Del = new System.Windows.Forms.Button();
            this.dgv_product = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.SuspendLayout();
            // 
            // Product_Name
            // 
            this.Product_Name.AutoSize = true;
            this.Product_Name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_Name.Location = new System.Drawing.Point(17, 52);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(97, 16);
            this.Product_Name.TabIndex = 0;
            this.Product_Name.Text = "Tên sản phẩm";
            // 
            // IdProducts
            // 
            this.IdProducts.AutoSize = true;
            this.IdProducts.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProducts.Location = new System.Drawing.Point(17, 19);
            this.IdProducts.Name = "IdProducts";
            this.IdProducts.Size = new System.Drawing.Size(19, 16);
            this.IdProducts.TabIndex = 1;
            this.IdProducts.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hình ảnh sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mô tả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "giá bán";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(171, 18);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(199, 20);
            this.txt_Id.TabIndex = 6;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(171, 48);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(199, 20);
            this.txt_Name.TabIndex = 7;
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(171, 84);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(128, 20);
            this.txt_Image.TabIndex = 8;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(171, 121);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(199, 20);
            this.txt_Quantity.TabIndex = 9;
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(171, 155);
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(199, 20);
            this.txt_mota.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(171, 194);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(199, 20);
            this.txt_price.TabIndex = 11;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Add.Location = new System.Drawing.Point(305, 81);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(65, 23);
            this.BTN_Add.TabIndex = 12;
            this.BTN_Add.Text = "Browser";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // BTN_Insert
            // 
            this.BTN_Insert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Insert.Location = new System.Drawing.Point(195, 233);
            this.BTN_Insert.Name = "BTN_Insert";
            this.BTN_Insert.Size = new System.Drawing.Size(75, 23);
            this.BTN_Insert.TabIndex = 13;
            this.BTN_Insert.Text = "Thêm";
            this.BTN_Insert.UseVisualStyleBackColor = true;
            this.BTN_Insert.Click += new System.EventHandler(this.BTN_Insert_Click);
            // 
            // StreamImg
            // 
            this.StreamImg.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|Bitmaps (*.bmp)|*.bmp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(395, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Update
            // 
            this.BTN_Update.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Update.Location = new System.Drawing.Point(380, 233);
            this.BTN_Update.Name = "BTN_Update";
            this.BTN_Update.Size = new System.Drawing.Size(75, 23);
            this.BTN_Update.TabIndex = 16;
            this.BTN_Update.Text = "Sửa";
            this.BTN_Update.UseVisualStyleBackColor = true;
            // 
            // BTN_Exit
            // 
            this.BTN_Exit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Exit.Location = new System.Drawing.Point(469, 233);
            this.BTN_Exit.Name = "BTN_Exit";
            this.BTN_Exit.Size = new System.Drawing.Size(75, 23);
            this.BTN_Exit.TabIndex = 17;
            this.BTN_Exit.Text = "Thoát";
            this.BTN_Exit.UseVisualStyleBackColor = true;
            // 
            // BTN_Del
            // 
            this.BTN_Del.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Del.Location = new System.Drawing.Point(286, 233);
            this.BTN_Del.Name = "BTN_Del";
            this.BTN_Del.Size = new System.Drawing.Size(75, 23);
            this.BTN_Del.TabIndex = 18;
            this.BTN_Del.Text = "Xoá";
            this.BTN_Del.UseVisualStyleBackColor = true;
            this.BTN_Del.Click += new System.EventHandler(this.BTN_Del_Click);
            // 
            // dgv_product
            // 
            this.dgv_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Location = new System.Drawing.Point(12, 280);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.Size = new System.Drawing.Size(544, 248);
            this.dgv_product.TabIndex = 19;
            this.dgv_product.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_RowHeaderMouseClick);
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 540);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.BTN_Del);
            this.Controls.Add(this.BTN_Exit);
            this.Controls.Add(this.BTN_Update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Insert);
            this.Controls.Add(this.BTN_Add);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IdProducts);
            this.Controls.Add(this.Product_Name);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product_Name;
        private System.Windows.Forms.Label IdProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Insert;
        private System.Windows.Forms.OpenFileDialog StreamImg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Update;
        private System.Windows.Forms.Button BTN_Exit;
        private System.Windows.Forms.Button BTN_Del;
        private System.Windows.Forms.DataGridView dgv_product;
    }
}