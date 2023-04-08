using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh
{
    public partial class Faccount : Form
    {
        public Faccount()
        {
            InitializeComponent();
            this.load_data_account();
        }
        public void load_data_account()
        {
            try
            {
                string query = "select Id, DisplayName from Accounts";
                DataProvide dataProvide = new DataProvide();
                dgv_account.DataSource=dataProvide.ExcuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Faccount_Load(object sender, EventArgs e)
        {

        }

        private void dgv_account_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN__Click(object sender, EventArgs e)
        {

        }

        private void BTN_changePass_Click(object sender, EventArgs e)
        {
            ChangePass frm = new ChangePass();
            frm.ShowDialog();
        }

        private void BTN_LogOut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
