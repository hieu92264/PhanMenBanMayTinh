using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;

namespace PhanMenBanMayTinh.BackEnd.Form_ProductsDAO
{
    public class AddProductsDAO
    {
        private AddProductsDAO() { }
        private static AddProductsDAO instance;

        public static AddProductsDAO Instance { 
            get => instance ?? (instance = new AddProductsDAO()); 
            private set => instance = value; 
        }
        public void Insert_Product(int Id, string Name, byte[] img, int sl, string mota, decimal giaban)
        {
            string query = "insert into Products values( @Id , @Name , @img , @sl , @mota , @giaban );";
             DataProvide dataProvide = new DataProvide();
             dataProvide.ExctueNonQuery1(query, new object[] {Id, Name, img, sl, mota, giaban});
        }
        public bool check_Id(int Id)
        {
            string query = "select *from Products where Id = " + Id;
            DataProvide dataProvide = new DataProvide();
            if (dataProvide.ExecuteQuery(query).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public void del_Products(int Id)
        {
            string query = "delete from Products where Id = " + Id;
            DataProvide dataProvide = new DataProvide();
            dataProvide.ExecuteNonQuery(query);
        }
        public void Update_Product(int Id, string Name, byte[] img, int sl, string mota, decimal giaban)
        {
            string query = "update Products set ProductName = @Name , ProductImage = @img , Quantity = @sl , MoTa = @mota , GiaBan = @giaban where Id = @Id ";
            DataProvide dataProvide = new DataProvide();
            dataProvide.ExctueNonQuery1(query, new object[] { Name, img, sl, mota, giaban, Id });
        }
        public void Update_Product1(int Id, string Name, int sl, string mota, decimal giaban)
        {
            string query = "update Products set ProductName = @Name , ProductImage = @img , Quantity = @sl , MoTa = @mota , GiaBan = @giaban where Id = @Id ";
            DataProvide dataProvide = new DataProvide();
            dataProvide.ExctueNonQuery1(query, new object[] { Name, sl, mota, giaban, Id });
        }
    }
}
