using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMenBanMayTinh
{
    public class Connection
    {
        private static string stringConnection = @"Data Source=ADMIN-PC;Initial Catalog=QLMT2;Integrated Security=True";

        //tao mot doi tuong ket noi den file sql
        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection); // thuc thi cac cau lenh truy van query
                SqlDataAdapter adapter = new SqlDataAdapter(command); // lay dl tu cau lenh truy van 
                adapter.Fill(data); // dua ketqua truy van vao doi tuong data
                connection.Close();
            }    
                return data;
        }
       
    }
}
