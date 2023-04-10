using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using PhanMenBanMayTinh.BackEnd.From_Account_DA0;

namespace PhanMenBanMayTinh
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
            AcceptButton = BTN_ResetPass;
        }
        
        private void BTN_ResetPass_Click(object sender, EventArgs e)
        {
            if (text_Id.Text != "" || text_pass_old.Text != "" && (text_pass_new != null && text_repeat_pass != null && text_pass_new.Text == text_repeat_pass.Text))
            {
                int username = Convert.ToInt32(text_Id.Text);
                string password = text_pass_old.Text;
                string newpass = text_pass_new.Text;
                if (ChangePassDAO.Instance.Load_check(username, password))
                {
                    ChangePassDAO.Instance.Load_Change_Pass(username, newpass);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            else MessageBox.Show("Nhập thiếu dữ liệu!");
        }
    }
}
