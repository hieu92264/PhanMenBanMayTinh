using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.BackEnd.From_Account_DA0
{
    public class AddAccountDAO
    {
        AddAccountDAO() { }
        private static AddAccountDAO instance;

        public static AddAccountDAO Instance { 
            get => instance ?? (instance = new AddAccountDAO()); 
            private set => instance = value; 
        }
        public void Insert_Account(int Id, string displayname, string Pass)
        {
            try
            {
                
                DataProvide dataProvide = new DataProvide();
                string query = "insert into Accounts(Id, DisplayName, Pass)\r\nvalues (" + Id + ", N'" + displayname + "', '" + Pass + "');";
                dataProvide.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
