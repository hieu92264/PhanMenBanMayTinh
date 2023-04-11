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
    public partial class Faccount : Form
    {
        public Faccount()
        {
            InitializeComponent();
            dgv_account.DataSource = FaccountDAO.Instance.load_data_account();
            BTN_Del.Enabled = false;
        }
        

        private void BTN_changePass_Click(object sender, EventArgs e)
        {
            ChangePass frm = new ChangePass();
            frm.ShowDialog();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            Add_Account frm = new Add_Account();
            frm.ShowDialog();
        }

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            if(dgv_account.SelectedRows.Count > 0) // selectedRow la list cac hang dc chon
            {
                // selectedCell la mot list cac o (cot) dc chon trong list cac hang dc chon
                int RowIndex = dgv_account.SelectedCells[1].RowIndex;
                int Id = Convert.ToInt32(dgv_account.Rows[RowIndex].Cells[0].Value.ToString());
                //dgv_account.Rows[RowIndex].Cells[0].Value.ToString() lay gia tri cua cell dau tien trong cac dong dc chon
                FaccountDAO.Instance.del_data_account(Id);
                dgv_account.Rows.RemoveAt(RowIndex);
            }
        }

        private void dgv_account_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv_account.SelectedRows.Count > 0)
            {
                BTN_Del.Enabled = true;
            }
        }
    }
}
