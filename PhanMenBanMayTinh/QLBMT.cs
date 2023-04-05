using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PhanMenBanMayTinh
{
    public partial class QLBMT : Form
    {
        public QLBMT()
        {
            InitializeComponent();
           /* try
            {
                string query = "select *from Products";
                //string stringconnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\PhanMenBanMayTinh\\PhanMenBanMayTinh\\QLMT.mdf;Integrated Security=True;Connect Timeout=30";
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\PhanMenBanMayTinh\\PhanMenBanMayTinh\\QLMT.mdf;Integrated Security=True;Connect Timeout=30";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader data = cmd.ExecuteReader();
                    DataTable Data = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(Data);
                    connection.Close();
                    dgv_Home.DataSource = Data;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            } */
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Tooltrip_Account.Selected)
            {
                Faccount frm = new Faccount();
                frm.Show();
            }
        }

        private void ToolStrip_Home_Click(object sender, EventArgs e)
        {
            if(ToolStrip_Home.Selected)
            {
                this.Show();
            }
        }
    }
}
