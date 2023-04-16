using Org.BouncyCastle.Math.Field;
using PhanMenBanMayTinh.BackEnd;
using PhanMenBanMayTinh.BackEnd.Form_ProductsDAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMenBanMayTinh.FrontEnd.Form_Products
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
            BTN_Insert.Enabled = false;
            BTN_Del.Enabled = false;
            BTN_Update.Enabled = false;
        }

        private void txt_Id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập chữ số!");
            }
        }

        private void BTN_Insert_Click(object sender, EventArgs e)
        {
            if(txt_Id.Text == ""|| txt_Name.Text == "")
            {
                MessageBox.Show("Chưa có mã định danh cho sản phầm!");
            } else
            {
                int Id = Convert.ToInt32(txt_Id.Text);
                if (AddProductsDAO.Instance.check_Id(Id)) MessageBox.Show("Id đã tồn tại!");
                else
                {
                    try
                    {
                        string name = txt_Name.Text;
                        string path = txt_Image.Text;
                        int sl = Convert.ToInt32(txt_Quantity.Text);
                        string mota = txt_mota.Text;
                        decimal giaban = Convert.ToDecimal(txt_price.Text);
                        byte[] img = File.ReadAllBytes(path); //convertImgToByte
                        AddProductsDAO.Instance.Insert_Product(Id, name, img, sl, mota, giaban);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog();
            if (StreamImg.ShowDialog() == DialogResult.OK)
            {
                txt_Image.Text = StreamImg.FileName;
                pictureBox1.ImageLocation = StreamImg.FileName;
            }
        }

        private void AddProducts_Load(object sender, EventArgs e)
        {
            this.dgv_product.DataSource = FormCenterDAO.Instance.load_dgv_Home();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv_product.Columns[2];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            if (txt_Id.Text != null) BTN_Insert.Enabled = true;
            txt_Id.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "Id"));
            txt_Name.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "ProductName"));
            txt_Quantity.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "Quantity"));
            txt_mota.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "MoTa"));
            txt_price.DataBindings.Add(new Binding("Text", dgv_product.DataSource, "GiaBan"));
            //MemoryStream ms = new MemoryStream();
        }

        private void dgv_product_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgv_product.SelectedRows.Count > 0)
            {
                BTN_Update.Enabled = true;
                BTN_Del.Enabled = true;
            }
        }
        

        private void BTN_Del_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                AddProductsDAO.Instance.del_Products(Convert.ToInt32(txt_Id.Text));
            }
        }
    }
}
