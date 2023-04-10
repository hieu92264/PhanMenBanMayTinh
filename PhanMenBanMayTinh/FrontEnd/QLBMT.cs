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
    }
}
