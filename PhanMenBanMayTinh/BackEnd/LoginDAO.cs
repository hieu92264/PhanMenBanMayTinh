using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.BackEnd
{
    public class LoginDAO
    {
        private static LoginDAO instance;
        private LoginDAO() { }

        public static LoginDAO Instance { 
            get => instance ?? (instance = new LoginDAO()); 
            private set => instance = value; 
        }
        public bool Check_Account(int username, string password)
        {
            
            try
            {
                string query = "select *from Accounts where Id = " + username + " and Pass ='" + password + "'";
                DataProvide dataProvide = new DataProvide();
                if (dataProvide.ExecuteQuery(query).Rows.Count > 0)
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
    }
}
