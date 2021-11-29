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
    public partial class FormQLTK : Form
    {
        DoAnContextDB db = new DoAnContextDB();
        
        public FormQLTK()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dl == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void dgvDSTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormQLTK_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> listtk = db.TaiKhoans.ToList();
            List<SuDung> listmayoff = db.SuDungs.Where(p=>p.TrangThai == "OFF").ToList();
            FillDataCBO(listmayoff);
            FillDataDGV(listtk);
        }

        private void FillDataCBO(List<SuDung> listmay)
        {
            cboMayOff.DataSource = listmay;
            cboMayOff.DisplayMember = "SoMay";
            cboMayOff.ValueMember = "TrangThai";
        }

        private void FillDataDGV(List<TaiKhoan> listtk)
        {
            dgvDSTK.Rows.Clear();
            foreach (var item in listtk)
            {
                int newRow = dgvDSTK.Rows.Add();
                dgvDSTK.Rows[newRow].Cells[0].Value = item.TenTK;
                dgvDSTK.Rows[newRow].Cells[1].Value = item.SoTien;
                float val = (float)item.SoTien/10000;
                TimeSpan time = TimeSpan.FromHours(val);
                dgvDSTK.Rows[newRow].Cells[2].Value = time.ToString("hh':'mm");
                
                if (item.SoTien > 0)
                    dgvDSTK.Rows[newRow].Cells[3].Value = "Cho phép";
                else
                    dgvDSTK.Rows[newRow].Cells[3].Value = "Không cho phép";

            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            FormTaoTK form = new FormTaoTK();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void btnNap_Click(object sender, EventArgs e)
        {
            if (txtNapTien.TextLength < 4)
            {
                errorProvider1.SetError(txtNapTien, "Số tiền tối thiểu trên 1000 chữ số !");
                return;
            }
            else
            {
                TaiKhoan naptien = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
                if (naptien != null)
                {
                    naptien.SoTien += Convert.ToInt32(txtNapTien.Text);

                    NapTien nt = new NapTien();
                    nt.MaTK = naptien.MaTK;
                    nt.NgayNap = DateTime.Today;
                    nt.SoTienNap = Convert.ToInt32(txtNapTien.Text);

                    db.NapTiens.AddOrUpdate(nt);
                    db.TaiKhoans.AddOrUpdate(naptien);
                    db.SaveChanges();
                  
                    txtNapTien.Clear();
                    loadDGV();

                    MessageBox.Show($"Nạp tiền {naptien.TenTK} thành công!", "Thông báo");
                    dgvDSTK.Rows[0].Selected = false;
                    if (CheckID(naptien.TenTK) != -1)
                        dgvDSTK.Rows[CheckID(naptien.TenTK)].Selected = true;
                }
                else
                    MessageBox.Show($"Nạp tiền {txtTimTK.Text} thất bại!", "Thông báo");
            }
        }
        private void loadDGV()
        {
            List<TaiKhoan> newlistTk = db.TaiKhoans.ToList();
            FillDataDGV(newlistTk);
        }

        private void dgvDSTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSTK.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                { 
                    dgvDSTK.CurrentCell.Selected = true;

                    txtTimTK.Text = dgvDSTK.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnTimTK_Click(object sender, EventArgs e)
        {
            TaiKhoan timTK = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
            if (timTK != null)
            {
                List<TaiKhoan> listtk = db.TaiKhoans.ToList();
                FillDataDGV(listtk);
                dgvDSTK.Rows[0].Selected = false;
                if (CheckID(timTK.TenTK) != -1)
                    dgvDSTK.Rows[CheckID(timTK.TenTK)].Selected = true;
            }
        }

        private void btnMoMay_Click(object sender, EventArgs e)
        {
            TaiKhoan momay = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
            if (momay != null)
            {
                SuDung sd1 = db.SuDungs.Where(p => p.SoMay == cboMayOff.Text).FirstOrDefault();
                db.SuDungs.Remove(sd1);
                db.SaveChanges();
                TaiKhoan tk1 = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
                SuDung sd2 = db.SuDungs.Where(p => p.MaTK == tk1.MaTK).FirstOrDefault();
                if (sd2 != null)
                {
                    sd2.TrangThai = "OFF";
                    db.SuDungs.AddOrUpdate(sd2);
                    db.SaveChanges();
                }
                db.SaveChanges();
                SuDung sd = new SuDung();
                sd.SoMay = cboMayOff.Text;
                TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
                sd.MaTK = tk.MaTK;
                sd.TienSuDung = (int?)0;
                sd.TrangThai = "ON";
                TaiKhoan tk4 = db.TaiKhoans.Where(p => p.TenTK == txtTimTK.Text).FirstOrDefault();
                SuDung sd4 = db.SuDungs.Where(p => p.MaTK == tk4.MaTK).FirstOrDefault();
                if (sd4 != null)
                {
                    sd4.TrangThai = "OFF";
                    db.SuDungs.AddOrUpdate(sd4);
                    db.SaveChanges();
                }
                List<SuDung> listmayoff = db.SuDungs.Where(p => p.TrangThai == "OFF").ToList();
                FillDataCBO(listmayoff);
                db.SuDungs.AddOrUpdate(sd);
                db.SaveChanges();
                MessageBox.Show($"Mở máy {sd.SoMay} cho tài khoản {sd.TaiKhoan.TenTK} thành công!", "Thông báo");
            }
            else
                MessageBox.Show($"Mở máy {cboMayOff.Text} cho tài khoản {txtTimTK.Text} thất bại!", "Thông báo");

        }

        private void txtTimTK_Click(object sender, EventArgs e)
        {
            txtTimTK.Clear();
        }

        private void txtNapTien_Click(object sender, EventArgs e)
        {
            txtNapTien.Clear();
        }
    }
}
