using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMenBanMayTinh
{
    public class DataProvide
    {
        private string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\PhanMenBanMayTinh\\PhanMenBanMayTinh\\QLMT.mdf;Integrated Security=True;Connect Timeout=30";
        public DataTable ExcuteQuery(string query) // tra ve mot bang database
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
        public int ExcuteNonQuery(string query) // tra ve so dong thanh cong
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(stringconnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        
    }
}