using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh
{
    public partial class Flogin : Form
    { 
        public Flogin()
        { 
            InitializeComponent();
            AcceptButton = BTN_Login;
            CancelButton = BTN_LoginExit;
        }

        private void Flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void BTN_LoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BTN_Login_Click(object sender, EventArgs e)
        {
            int username = Convert.ToInt32(text_LoginName.Text);
            string password = text_LoginPass.Text;
            try
            {
                string query = "select *from Accounts where Id = " + username + " and Pass ='" + password + "'";
                DataProvide dataProvide = new DataProvide();
                if(dataProvide.ExcuteQuery(query).Rows.Count > 0)
                {
                    this.Hide();
                    QLBMT frm = new QLBMT();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void text_LoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) && char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

    }
            
}
