using PhanMenBanMayTinh.BackEnd.From_Account_DA0;
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
            AcceptButton = BTN_Add;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textId.Text);
            string displayname = text_Display_name.Text;
            string Pass = text_Pass.Text;
            AddAccountDAO.Instance.Insert_Account(Id, displayname, Pass);
            this.Close();
        }
    }
}
