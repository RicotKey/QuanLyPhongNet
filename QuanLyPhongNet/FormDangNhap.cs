using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongNet
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtTenDN.Text != "QuanLyPhongNet")
            {
                errorProvider1.SetError(txtTenDN, "Sai tên đăng nhập !");
                return;
            }
            if (txtMK.Text != "quanlyphongnet")
            {
                errorProvider1.SetError(txtMK, "Sai mật khẩu !");
                return;
            }
            if (txtMK.Text == "quanlyphongnet" && txtTenDN.Text == "QuanLyPhongNet")
            {

                Form1 form = new Form1();
                form.FormClosed += new FormClosedEventHandler(form_FormClosed);
                form.Show();
                this.Hide();
                if(txtTenDN.Text != "QuanLyPhongNet")
                {
                    errorProvider1.SetError(txtTenDN, "Sai tên đăng nhập !");
                }
                if (txtMK.Text != "quanlyphongnet")
                {
                    errorProvider1.SetError(txtMK, "Sai mật khẩu !");
                }
            }
            else
            {
                txtSai.Text = "Nhập sai tài khoản!";
            }
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
