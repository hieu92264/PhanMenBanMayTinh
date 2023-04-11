using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh
{
    public class DataProvide
    {
        private string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\PhanMenBanMayTinh\\PhanMenBanMayTinh\\DataProvide.mdf;Integrated Security=True";
        //private string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\DataProvide.mdf;Integrated Security=True";
        public DataProvide() {}
        //private string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename="+Path.GetFullPath(C: \Users\Admin\source\repos\PhanMenBanMayTinh\PhanMenBanMayTinh\D) +@"\QLMT.mdf;Integrated Security=True;Connect Timeout=30";
        public DataTable ExecuteQuery(string query) // tra ve mot bang database
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connection.Close();
            }
            return data;
        }
        public void ExecuteNonQuery(string query) // tra ve so dong thanh cong
        {
            SqlConnection connection = new SqlConnection(stringconnection);
            try { 
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();              
                MessageBox.Show("Thay đổi dữ liệu thành công!");
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
           // return data;
        }
        public object ExcuteScalar(string query) // tra ve so dong thanh cong
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}