using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.BackEnd.From_Account_DA0
{
    public class ChangePassDAO
    {
        private static ChangePassDAO instance;
        private ChangePassDAO() { }

        public static ChangePassDAO Instance {
            get => instance ?? (instance = new ChangePassDAO()); 
            private set => instance = value; 
        }
        public bool Load_check(int username, string password)
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
        public void Load_Change_Pass(int username, string newpass) {
            try
            {

                    DataProvide dataProvide = new DataProvide();
                    string query = "update Accounts set Pass = '" + newpass + "' where Id = " + username;
                    dataProvide.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
