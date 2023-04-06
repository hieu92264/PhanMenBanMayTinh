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
        }
        public void load_dgv_Home()
        {
            try
            {
                string query = "select *from Products";
                DataProvide dataProvide = new DataProvide();
                dgv_Home.DataSource =dataProvide.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tooltrip_Account.Selected)
            {
                Faccount frm = new Faccount();
                frm.Show();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            if(textSearch != null)
            {
                string query = "select *from Products where ProductName like '%"+textSearch.Text+"%'";
                DataProvide dataProvide = new DataProvide();
                dgv_Home.DataSource = null;
                dgv_Home.DataSource =dataProvide.ExcuteQuery(query);
            }
        }
    }
}
