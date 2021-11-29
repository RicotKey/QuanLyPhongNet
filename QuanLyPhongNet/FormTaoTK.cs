using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongNet.Model;
namespace QuanLyPhongNet
{
    public partial class FormTaoTK : Form
    {
        DoAnContextDB db = new DoAnContextDB();
        public FormTaoTK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormQLTK form = new FormQLTK();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void FormTaoTK_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> listtk = db.TaiKhoans.ToList();
            FillDataDGV(listtk);
        }
        private void FillDataDGV(List<TaiKhoan> listtk)
        {
            dgvDSTK.Rows.Clear();
            foreach (var item in listtk)
            {
                int newRow = dgvDSTK.Rows.Add();
                dgvDSTK.Rows[newRow].Cells[0].Value = item.TenTK;
                dgvDSTK.Rows[newRow].Cells[1].Value = item.SoTien;
                float val = (float)item.SoTien / 10000;
                TimeSpan time = TimeSpan.FromHours(val);
                dgvDSTK.Rows[newRow].Cells[2].Value = time.ToString("hh':'mm");
                if (item.SoTien > 0)
                    dgvDSTK.Rows[newRow].Cells[3].Value = "Cho phép";
                else
                    dgvDSTK.Rows[newRow].Cells[3].Value = "Không cho phép";

            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                if (CheckTenTK(txtTenTK.Text) == -1)
                {
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenTK = txtTenTK.Text;
                    tk.MatKhau = txtMK.Text;
                    tk.SoTien = Convert.ToInt32(txtNapTien.Text);
                    NapTien nt = new NapTien();
                    nt.MaTK = tk.MaTK;
                    nt.NgayNap = DateTime.Today;
                    nt.SoTienNap = Convert.ToInt32(txtNapTien.Text);

                   

                    db.TaiKhoans.Add(tk);
                    
                    db.NapTiens.AddOrUpdate(nt);
                    db.SaveChanges();
                    loadForm();
                    loadDGV();
                    dgvDSTK.Rows[0].Selected = false;
                    if (CheckID(tk.TenTK) != -1)
                        dgvDSTK.Rows[CheckID(tk.TenTK)].Selected = true;
                    MessageBox.Show($"Thêm tài khoản {tk.TenTK} thành công!", "Thông báo");

                }
                else
                {
                    MessageBox.Show($"Thêm tài khoản {txtTenTK.Text} thất bại!", "Thông báo");

                }
            }
        }

        private int CheckID(string ID)
        {
            for (int i = 0; i < dgvDSTK.Rows.Count; i++)
            {
                if (dgvDSTK.Rows[i].Cells[0].Value != null)
                {
                    if (dgvDSTK.Rows[i].Cells[0].Value.ToString() == ID)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private void loadDGV()
        {
            List<TaiKhoan> newlistTk = db.TaiKhoans.ToList();
            FillDataDGV(newlistTk);
        }

        private void loadForm()
        {
            txtTenTK.Clear();
            txtMK.Clear();
            txtNapTien.Clear();

        }
        private bool CheckDataInput()
        {
            if (txtTenTK.Text == "" || txtMK.Text == "" || txtNapTien.Text == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtNapTien.Text.Length < 4)
            {
                MessageBox.Show("Tiền phải trên 1000 đồng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                float kq = 0;
                bool ketqua = float.TryParse(txtNapTien.Text, out kq);
                if (ketqua != true)
                {
                    MessageBox.Show("Nhập số tiền không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

            }
            return true;
        }
        private int CheckTenTK(string tenTk)
        {
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tenTk).FirstOrDefault();
            if (tk != null)
                return 1;
            else
            {
                return -1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                TaiKhoan suaTK = db.TaiKhoans.Where(p => p.TenTK == txtTenTK.Text).FirstOrDefault();
                if (suaTK != null)
                {
                    suaTK.TenTK = txtTenTK.Text;
                    suaTK.MatKhau = txtMK.Text;

                    db.TaiKhoans.AddOrUpdate(suaTK);
                    db.SaveChanges();

                    loadForm();
                    loadDGV();

                    MessageBox.Show($"Sửa tài khoản {suaTK.TenTK} thành công!", "Thông báo");

                }
                else
                    MessageBox.Show($"Sửa tài khoản {suaTK.TenTK} thất bại!", "Thông báo");
            }
        }

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (dgvDSTK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSTK.CurrentCell.Selected = true;

                    txtTenTK.Text = dgvDSTK.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();

                    txtNapTien.Text = dgvDSTK.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtNapTien.Enabled = false;
                }
                TaiKhoan MK = db.TaiKhoans.Where(p => p.TenTK == txtTenTK.Text).FirstOrDefault();
                if (MK != null)
                {
                    txtMK.Text = MK.MatKhau;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
            txtNapTien.Enabled = true;
            txtMK.Clear();
            txtNapTien.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckDataInput() == true)
            {
                TaiKhoan xoaTK = db.TaiKhoans.Where(p => p.TenTK == txtTenTK.Text).FirstOrDefault();
                NapTien nt = db.NapTiens.Where(p => p.MaTK == xoaTK.MaTK).FirstOrDefault();
                if (xoaTK != null)
                {   
                    
                    xoaTK.TenTK = txtTenTK.Text;
                    xoaTK.MatKhau = txtMK.Text;
                    xoaTK.SoTien = Convert.ToInt32(txtNapTien.Text);

                    DialogResult del = MessageBox.Show($"Bạn chắc chắn muốn xoá dữ liệu tài khoản {txtTenTK.Text}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (del == DialogResult.Yes)
                    {
                        db.NapTiens.Remove(nt);
                        db.TaiKhoans.Remove(xoaTK);

                        db.SaveChanges();

                        loadForm();
                        loadDGV();
                        MessageBox.Show($"Xoá tài khoản {txtTenTK.Text} thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show($"Xoá tài khoản {txtTenTK.Text} thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
