using PhanMenBanMayTinh.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMenBanMayTinh
{
    public partial class QLBMT : Form
    {
        public QLBMT()
        {
            InitializeComponent();
            this.load_dgv_Home();
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
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq != DialogResult.OK)
            {
                e.Cancel = true;
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
            if(TS_All_Products.Checked)
            {
                this.load_dgv_Home();
            }
        }

        private void Menu_Product_Dell_Click(object sender, EventArgs e)
        {
            if(TS_All_Products.Checked) {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_All_Products_Dell();
            }
        }

        private void TS_Accer_Click(object sender, EventArgs e)
        {
            if (TS_Accer.Checked)
            {
                dgv_Home.DataSource = FormCenterDAO.Instance.find_All_Products_Accer();
            }

        }
    }
}
