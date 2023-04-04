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
    public partial class QLBMT : Form
    {
        public QLBMT()
        {
            InitializeComponent();
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
