namespace PhanMenBanMayTinh
{
    partial class QLBMT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBMT));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_All_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Product_Dell = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Vostro = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Latidue = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Inspiron = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_fix_product = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Accer = new System.Windows.Forms.ToolStripMenuItem();
            this.Tooltrip_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.hoáĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_CreateBill = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Update_Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_View_Infor_Bill = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_financial_statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Home = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct,
            this.Tooltrip_Account,
            this.hoáĐơnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuProduct
            // 
            this.MenuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_All_Products,
            this.Menu_Product_Dell,
            this.TS_fix_product,
            this.TS_Accer});
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Size = new System.Drawing.Size(72, 20);
            this.MenuProduct.Text = "Sản phẩm";
            // 
            // TS_All_Products
            // 
            this.TS_All_Products.Checked = true;
            this.TS_All_Products.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_All_Products.Name = "TS_All_Products";
            this.TS_All_Products.Size = new System.Drawing.Size(234, 22);
            this.TS_All_Products.Text = "Tất cả sản phẩm";
            this.TS_All_Products.Click += new System.EventHandler(this.TS_All_Products_Click);
            // 
            // Menu_Product_Dell
            // 
            this.Menu_Product_Dell.Checked = true;
            this.Menu_Product_Dell.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu_Product_Dell.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Vostro,
            this.TS_Latidue,
            this.TS_Inspiron});
            this.Menu_Product_Dell.Name = "Menu_Product_Dell";
            this.Menu_Product_Dell.Size = new System.Drawing.Size(234, 22);
            this.Menu_Product_Dell.Text = "Laptop Dell";
            this.Menu_Product_Dell.Click += new System.EventHandler(this.Menu_Product_Dell_Click);
            // 
            // TS_Vostro
            // 
            this.TS_Vostro.Checked = true;
            this.TS_Vostro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_Vostro.Name = "TS_Vostro";
            this.TS_Vostro.Size = new System.Drawing.Size(140, 22);
            this.TS_Vostro.Text = "Dell Vostro";
            this.TS_Vostro.Click += new System.EventHandler(this.TS_Vostro_Click);
            // 
            // TS_Latidue
            // 
            this.TS_Latidue.Checked = true;
            this.TS_Latidue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_Latidue.Name = "TS_Latidue";
            this.TS_Latidue.Size = new System.Drawing.Size(140, 22);
            this.TS_Latidue.Text = "Dell Latidue";
            this.TS_Latidue.Click += new System.EventHandler(this.TS_Latidue_Click);
            // 
            // TS_Inspiron
            // 
            this.TS_Inspiron.Checked = true;
            this.TS_Inspiron.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_Inspiron.Name = "TS_Inspiron";
            this.TS_Inspiron.Size = new System.Drawing.Size(140, 22);
            this.TS_Inspiron.Text = "Dell Inspiron";
            this.TS_Inspiron.Click += new System.EventHandler(this.TS_Inspiron_Click);
            // 
            // TS_fix_product
            // 
            this.TS_fix_product.Checked = true;
            this.TS_fix_product.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_fix_product.Name = "TS_fix_product";
            this.TS_fix_product.Size = new System.Drawing.Size(234, 22);
            this.TS_fix_product.Text = "Chỉnh sửa thông tin sản phẩm";
            // 
            // TS_Accer
            // 
            this.TS_Accer.Checked = true;
            this.TS_Accer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TS_Accer.Name = "TS_Accer";
            this.TS_Accer.Size = new System.Drawing.Size(234, 22);
            this.TS_Accer.Text = "Laptop Accer";
            this.TS_Accer.Click += new System.EventHandler(this.TS_Accer_Click);
            // 
            // Tooltrip_Account
            // 
            this.Tooltrip_Account.Name = "Tooltrip_Account";
            this.Tooltrip_Account.Size = new System.Drawing.Size(64, 20);
            this.Tooltrip_Account.Text = "Account";
            this.Tooltrip_Account.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // hoáĐơnToolStripMenuItem
            // 
            this.hoáĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_CreateBill,
            this.TS_Update_Bill,
            this.TS_View_Infor_Bill,
            this.TS_financial_statistics});
            this.hoáĐơnToolStripMenuItem.Name = "hoáĐơnToolStripMenuItem";
            this.hoáĐơnToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.hoáĐơnToolStripMenuItem.Text = "Hoá đơn";
            // 
            // Menu_CreateBill
            // 
            this.Menu_CreateBill.Name = "Menu_CreateBill";
            this.Menu_CreateBill.Size = new System.Drawing.Size(203, 22);
            this.Menu_CreateBill.Text = "Tạo hoá đơn";
            this.Menu_CreateBill.Click += new System.EventHandler(this.Menu_CreateBill_Click);
            // 
            // TS_Update_Bill
            // 
            this.TS_Update_Bill.Name = "TS_Update_Bill";
            this.TS_Update_Bill.Size = new System.Drawing.Size(203, 22);
            this.TS_Update_Bill.Text = "Chỉnh sửa hoá đơn";
            // 
            // TS_View_Infor_Bill
            // 
            this.TS_View_Infor_Bill.Name = "TS_View_Infor_Bill";
            this.TS_View_Infor_Bill.Size = new System.Drawing.Size(203, 22);
            this.TS_View_Infor_Bill.Text = "Xem thông tin bán hàng";
            // 
            // TS_financial_statistics
            // 
            this.TS_financial_statistics.Name = "TS_financial_statistics";
            this.TS_financial_statistics.Size = new System.Drawing.Size(203, 22);
            this.TS_financial_statistics.Text = "Thống kê tài chính";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(167, 39);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(254, 20);
            this.textSearch.TabIndex = 2;
            // 
            // BTNSearch
            // 
            this.BTNSearch.Location = new System.Drawing.Point(450, 36);
            this.BTNSearch.Name = "BTNSearch";
            this.BTNSearch.Size = new System.Drawing.Size(75, 23);
            this.BTNSearch.TabIndex = 3;
            this.BTNSearch.Text = "Tìm kiếm";
            this.BTNSearch.UseVisualStyleBackColor = true;
            this.BTNSearch.Click += new System.EventHandler(this.BTNSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập sản phẩm cần tìm ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.BTNSearch);
            this.panel1.Location = new System.Drawing.Point(110, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 83);
            this.panel1.TabIndex = 5;
            // 
            // dgv_Home
            // 
            this.dgv_Home.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Home.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_Home.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Home.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Home.GridColor = System.Drawing.Color.DarkGray;
            this.dgv_Home.Location = new System.Drawing.Point(0, 193);
            this.dgv_Home.Name = "dgv_Home";
            this.dgv_Home.Size = new System.Drawing.Size(872, 429);
            this.dgv_Home.TabIndex = 5;
            // 
            // QLBMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 622);
            this.Controls.Add(this.dgv_Home);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLBMT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán máy tính";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLBMT_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct;
        private System.Windows.Forms.ToolStripMenuItem Menu_Product_Dell;
        private System.Windows.Forms.ToolStripMenuItem TS_Vostro;
        private System.Windows.Forms.ToolStripMenuItem TS_Latidue;
        private System.Windows.Forms.ToolStripMenuItem TS_Inspiron;
        private System.Windows.Forms.ToolStripMenuItem Tooltrip_Account;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Home;
        private System.Windows.Forms.ToolStripMenuItem hoáĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_fix_product;
        private System.Windows.Forms.ToolStripMenuItem Menu_CreateBill;
        private System.Windows.Forms.ToolStripMenuItem TS_Update_Bill;
        private System.Windows.Forms.ToolStripMenuItem TS_View_Infor_Bill;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_financial_statistics;
        private System.Windows.Forms.ToolStripMenuItem TS_All_Products;
        private System.Windows.Forms.ToolStripMenuItem TS_Accer;
    }
}

