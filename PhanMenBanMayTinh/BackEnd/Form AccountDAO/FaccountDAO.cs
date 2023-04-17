using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.BackEnd.From_Account_DA0
{
    public class FaccountDAO
    {
        private FaccountDAO() { }
        private static FaccountDAO instance;

        public static FaccountDAO Instance {
            get => instance ?? (instance = new FaccountDAO());
            private set => instance = value;
        }
        public DataTable load_data_account()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "select Id, DisplayName, Type from Accounts";
                DataProvide dataProvide = new DataProvide();
                data = dataProvide.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }

        public void del_data_account(int Id)
        {
            string query = "DELETE FROM Accounts WHERE ID =" + Id + "";
            DataProvide dataProvide = new DataProvide();
            dataProvide.ExecuteNonQuery(query);
        }
        public void update_Account(string type, string UserName, string id)
        {
            int Id = Convert.ToInt32(id);
            int Type = Convert.ToInt32(type);
            string query = "update Accounts set Type = " + Type + ", DisplayName = N'" + UserName + "' where Id = "+Id+"";
            DataProvide dataProvide = new DataProvide();
            dataProvide.ExecuteNonQuery(query);
        }
    }
}
