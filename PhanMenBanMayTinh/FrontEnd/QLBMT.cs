using PhanMenBanMayTinh.BackEnd;
using PhanMenBanMayTinh.FrontEnd.Form_Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMenBanMayTinh
{
    public partial class QLBMT : Form
    {
        public bool isClose = true;
        public QLBMT()
        {
            InitializeComponent();
            AcceptButton = BTNSearch;
            if (LoginDAO.Instance.type == 0)
            {
                TS_fix_product.Enabled = false;
                TS_Update_Bill.Enabled = false;
                TS_financial_statistics.Enabled = false;
            }
            textSearch.Focus();
        }
        public void load_dgv_Home()
        {
            dgv_Home.DataSource = FormCenterDAO.Instance.load_dgv_Home();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Tooltrip_Account.Selected)
            {
                Faccount frm = new Faccount();
                frm.ShowDialog();
            }
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if (textSearch != null)
            {

                dgv_Home.DataSource = FormCenterDAO.Instance.Load_Search(textSearch.Text);
            }
        }

        private void QLBMT_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClose)
            {
                DialogResult kq;
                kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (kq != DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Menu_CreateBill_Click(object sender, EventArgs e)
        {
            CreateBill frm = new CreateBill();
            frm.ShowDialog();
        }

        private void TS_Vostro_Click(object sender, EventArgs e)
        {
            if (TS_Vostro.Checked)
            {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_vostro();
            }
            else
            {
                TS_Vostro.Checked = true;
            }
        }

        private void TS_Latidue_Click(object sender, EventArgs e)
        {
            if (TS_Latidue.Checked)
            {
                dgv_Home.DataSource = null;
                dgv_Home.DataSource = FormCenterDAO.Instance.find_Latidue();
            }
        }

        private void TS_Inspiron_Click(object sender, EventArgs e)
        {
            if (TS_Inspiron.Checked)
            {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_Inspiron();
            }
        }

        private void TS_All_Products_Click(object sender, EventArgs e)
        {
            if (TS_All_Products.Checked)
            {
                this.load_dgv_Home();
            }
        }

        private void Menu_Product_Dell_Click(object sender, EventArgs e)
        {
            if (TS_All_Products.Checked)
            {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_All_Products_Dell();
            }
        }

        private void TS_Accer_Click(object sender, EventArgs e)
        {
            if (TS_Accer.Checked)
            {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_All_Products_Acer();
            }

        }

        private void QLBMT_Load(object sender, EventArgs e)
        {
            this.load_dgv_Home();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv_Home.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void TS_fix_product_Click(object sender, EventArgs e)
        {
            AddProducts addProducts = new AddProducts();
            addProducts.ShowDialog();
        }

        private void TS_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                isClose = false;
                Flogin frm = new Flogin();
                this.Close();
                frm.ShowDialog();
            }
        }

        private void QLBMT_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(isClose) Application.Exit();
        }
    }
}
