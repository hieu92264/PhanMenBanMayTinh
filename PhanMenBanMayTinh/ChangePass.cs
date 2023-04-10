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


namespace PhanMenBanMayTinh
{
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {

        }
        private bool Load_check(int username, string password) 
        {
            try
            {
                string query = "select *from Accounts where Id = " + username + " and Pass ='" + password + "'";
                DataProvide dataProvide = new DataProvide();
                    if (dataProvide.ExcuteQuery(query).Rows.Count > 0)
                    {
                        return true;
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
            return false;
        }
        private void BTN_ResetPass_Click(object sender, EventArgs e)
        {
            if (text_Id.Text != "" || text_pass_old.Text !="" && (text_pass_new != null && text_repeat_pass != null && text_pass_new.Text == text_repeat_pass.Text))
            {
                int username = Convert.ToInt32(text_Id.Text);
                string password = text_pass_old.Text;
                string newpass = text_pass_new.Text;
                    try
                    {
                        if (this.Load_check(username, password))
                        {
                        
                            DataProvide dataProvide = new DataProvide();
                            

                            string query = "update Accounts set Pass = '" + newpass + "' where Id = " + username + "";
                            dataProvide.ExcuteNonQuery(query);

                               /* if (dataProvide.ExcuteNonQuery(query) > 0)
                                {
                                    MessageBox.Show("Đổi mật khẩu thành công!");
                                } */
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
            else MessageBox.Show("Nhập thiếu dữ liệu!");
        }
    }
}
