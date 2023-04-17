using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.BackEnd
{
    public class FormCenterDAO
    {
        private static FormCenterDAO instance;
        private FormCenterDAO() { }

        public static FormCenterDAO Instance {
            get => instance ?? (instance = new FormCenterDAO()); 
            private set => instance = value;
        }
        public DataTable load_dgv_Home()
        {
            DataTable data = null;
            try
            {
                string query = "select *from Products";
                DataProvide dataProvide = new DataProvide();
                data = dataProvide.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return data;
        }
        public DataTable Load_Search(string text)
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%" + text + "%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            return data;
        }
        public DataTable find_vostro()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%vostro%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            return data;
        }
        public DataTable find_Latidue()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%latidue%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            //MessageBox.Show("Tìm thành công");
            return data;
        }
        public DataTable find_Inspiron()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%inspiron%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            return data;
        }
        public DataTable find_All_Products_Dell()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%Dell%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            return data;
        }
        public DataTable find_All_Products_Acer()
        {
            DataTable data = null;
            string query = "select *from Products where ProductName like '%Acer%'";
            DataProvide dataProvide = new DataProvide();
            data = dataProvide.ExecuteQuery(query);
            return data;
        }
    }
}
