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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLBMT));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStrip_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Product_Dell = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Vostro = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Latidue = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Inspiron = new System.Windows.Forms.ToolStripMenuItem();
            this.Tooltrip_Account = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textSearch = new System.Windows.Forms.TextBox();
            this.BTNSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Home,
            this.MenuProduct,
            this.Tooltrip_Account});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStrip_Home
            // 
            this.ToolStrip_Home.Name = "ToolStrip_Home";
            this.ToolStrip_Home.Size = new System.Drawing.Size(71, 20);
            this.ToolStrip_Home.Text = "Trang chủ";
            this.ToolStrip_Home.Click += new System.EventHandler(this.ToolStrip_Home_Click);
            // 
            // MenuProduct
            // 
            this.MenuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Product_Dell});
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Size = new System.Drawing.Size(72, 20);
            this.MenuProduct.Text = "Sản phẩm";
            // 
            // Menu_Product_Dell
            // 
            this.Menu_Product_Dell.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Vostro,
            this.ToolStrip_Latidue,
            this.ToolStrip_Inspiron});
            this.Menu_Product_Dell.Name = "Menu_Product_Dell";
            this.Menu_Product_Dell.Size = new System.Drawing.Size(180, 22);
            this.Menu_Product_Dell.Text = "Laptop Dell";
            // 
            // ToolStrip_Vostro
            // 
            this.ToolStrip_Vostro.Name = "ToolStrip_Vostro";
            this.ToolStrip_Vostro.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Vostro.Text = "Dell Vostro";
            // 
            // ToolStrip_Latidue
            // 
            this.ToolStrip_Latidue.Name = "ToolStrip_Latidue";
            this.ToolStrip_Latidue.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Latidue.Text = "Dell Latidue";
            // 
            // ToolStrip_Inspiron
            // 
            this.ToolStrip_Inspiron.Name = "ToolStrip_Inspiron";
            this.ToolStrip_Inspiron.Size = new System.Drawing.Size(180, 22);
            this.ToolStrip_Inspiron.Text = "Dell Inspiron";
            // 
            // Tooltrip_Account
            // 
            this.Tooltrip_Account.Name = "Tooltrip_Account";
            this.Tooltrip_Account.Size = new System.Drawing.Size(64, 20);
            this.Tooltrip_Account.Text = "Account";
            this.Tooltrip_Account.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            this.panel1.Location = new System.Drawing.Point(73, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 100);
            this.panel1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 219);
            this.dataGridView1.TabIndex = 5;
            // 
            // QLBMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLBMT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán máy tính";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Home;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct;
        private System.Windows.Forms.ToolStripMenuItem Menu_Product_Dell;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Vostro;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Latidue;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Inspiron;
        private System.Windows.Forms.ToolStripMenuItem Tooltrip_Account;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button BTNSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

