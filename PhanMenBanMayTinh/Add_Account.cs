using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh
{
    public partial class Add_Account : Form
    {
        public Add_Account()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(textId.Text);
                string displayname = text_Display_name.Text;
                string Pass = text_Pass.Text;
                DataProvide dataProvide = new DataProvide();
                string query = "insert into Accounts(Id, DisplayName, Pass)\r\nvalues (" + Id + ", N'" + displayname + "', '" + Pass + "');";
                dataProvide.ExcuteNonQuery(query);
               /* if (dataProvide.ExcuteNonQuery(query) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                } */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
