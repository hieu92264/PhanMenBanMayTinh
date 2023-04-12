using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public int type = 0;
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
        public void get_type(int username)
        {
            string query = "select Type from Accounts where Id = " + username + "";
            DataProvide dataProvide = new DataProvide();
            object result = dataProvide.ExcuteScalar(query);
            if(result != null)
            {
               result = result.ToString();
            }
            type = Convert.ToInt32(result);
        }
    }
}
