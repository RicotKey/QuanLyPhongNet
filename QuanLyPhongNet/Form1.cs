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
    public partial class Form1 : Form
    {
        DoAnContextDB db = new DoAnContextDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SuDung> listSD = db.SuDungs.ToList();
            
            
            FillDataDGV(listSD);
            
            
            
        }

        private void FillDataDGV(List<SuDung> listSD)
        {
            dgvDSPM.Rows.Clear();
            List<SuDung> mayon = db.SuDungs.Where(p => p.TrangThai == "ON").ToList();
            foreach (var item in mayon)
            {
                int newRow = dgvDSPM.Rows.Add();
                dgvDSPM.Rows[newRow].Cells[0].Value = item.SoMay;
                dgvDSPM.Rows[newRow].Cells[1].Value = item.TaiKhoan.TenTK;
                
                float val = (float)item.TienSuDung / 10000;
                TimeSpan time = TimeSpan.FromHours(val);
                dgvDSPM.Rows[newRow].Cells[2].Value = time.ToString("hh':'mm");
                float val1 = ((float)item.TaiKhoan.SoTien-(float)item.TienSuDung) / 10000;
                TimeSpan time1 = TimeSpan.FromHours(val1);
                dgvDSPM.Rows[newRow].Cells[3].Value = time1.ToString("hh':'mm");
                dgvDSPM.Rows[newRow].Cells[4].Value = (float)item.TaiKhoan.SoTien - (float)item.TienSuDung;
                dgvDSPM.Rows[newRow].Cells[5].Value = item.TrangThai;   

            }
            List<SuDung> mayoff = db.SuDungs.Where(p => p.TrangThai == "OFF").ToList();
            foreach (var item in mayoff)
            {
                int newRow = dgvDSPM.Rows.Add();		

                dgvDSPM.Rows[newRow].Cells[0].Value = item.SoMay;
                dgvDSPM.Rows[newRow].Cells[5].Value = item.TrangThai;

            }
        }


        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormQLTK form = new FormQLTK();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format($"Hôm nay là ngày: {DateTime.Now.ToString("dd/MM/yyyy")}");
        }

        private void quảnLýTàiKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dl == DialogResult.OK)
            {
                Close();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
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

        private void btnTimMay_Click(object sender, EventArgs e)
        {
            SuDung timMay = db.SuDungs.Where(p => p.SoMay == txtTimMay.Text).FirstOrDefault();
            if (timMay != null)
            {
                List<SuDung> listTimMay = db.SuDungs.ToList();
                FillDataDGV(listTimMay);
                dgvDSPM.Rows[0].Selected = false;
                if (CheckID(timMay.SoMay) != -1)
                {
                    dgvDSPM.Rows[CheckID(timMay.SoMay)].Selected = true;
                    txtTimMay.Text = timMay.SoMay;
                }
            }
        }

        private int CheckID(string ID)
        {
            for (int i = 0; i < dgvDSPM.Rows.Count; i++)
            {
                if (dgvDSPM.Rows[i].Cells[0].Value != null)
                {
                    if (dgvDSPM.Rows[i].Cells[0].Value.ToString() == ID)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        private int CheckON(string ID)
        {
            List<SuDung> mayoff = db.SuDungs.Where(p => p.TrangThai == "OFF").ToList();
            foreach (var item in mayoff)
            {
                if (ID == item.SoMay)
                    return -1;
            }

            return 1;
        }
        private void btnOn_Click(object sender, EventArgs e)
        {
            
            
           if(CheckON(txtTimMay.Text) == -1 )
            
            {
                SuDung turnOn = db.SuDungs.Where(p => p.SoMay == txtTimMay.Text).FirstOrDefault();
                if (turnOn != null)
                {
                    turnOn.TrangThai = "ON";


                    db.SuDungs.AddOrUpdate(turnOn);
                    db.SaveChanges();

                    txtTimMay.Clear();
                    loadDGV();

                    MessageBox.Show($"Mở máy {turnOn.SoMay} thành công!", "Thông báo");
                    dgvDSPM.Rows[0].Selected = false;
                    if (CheckID(turnOn.SoMay) != -1)
                    {
                        dgvDSPM.Rows[CheckID(turnOn.SoMay)].Selected = true;
                        txtTimMay.Text = turnOn.SoMay;
                    }
                }
            }
           else
                MessageBox.Show($"Máy {txtTimMay.Text} đang mở!", "Thông báo");

        }
        private void loadDGV()
        {
            List<SuDung> newlistSD = db.SuDungs.ToList();
            FillDataDGV(newlistSD);
        }

        private void dgvDSPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSPM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSPM.CurrentCell.Selected = true;

                    txtTimMay.Text = dgvDSPM.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (CheckON(txtTimMay.Text) == 1)

            {
                SuDung turnOFF = db.SuDungs.Where(p => p.SoMay == txtTimMay.Text).FirstOrDefault();
                if (turnOFF != null)
                {
                    turnOFF.TrangThai = "OFF";


                    db.SuDungs.AddOrUpdate(turnOFF);
                    db.SaveChanges();

                    txtTimMay.Clear();
                    loadDGV();

                    MessageBox.Show($"Tắt máy {turnOFF.SoMay} thành công!", "Thông báo");
                    dgvDSPM.Rows[0].Selected = false;
                    if (CheckID(turnOFF.SoMay) != -1)
                    {
                        dgvDSPM.Rows[CheckID(turnOFF.SoMay)].Selected = true;
                        txtTimMay.Text = turnOFF.SoMay;
                    }
                }
            }
            else
                MessageBox.Show($"Máy {txtTimMay.Text} đang tắt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnNapTien_Click(object sender, EventArgs e)
        {
            if (txtNapTien.TextLength < 4)
            {
                errorProvider1.SetError(txtNapTien, "Số tiền tối thiểu trên 1000 chữ số !");
                return;
            }
            else
            {
                SuDung naptien = db.SuDungs.Where(p => p.SoMay == txtTimMay.Text).FirstOrDefault();
                if (naptien != null)
                {
                    naptien.TaiKhoan.SoTien += Convert.ToInt32(txtNapTien.Text);

                    NapTien nt = new NapTien();
                    nt.MaTK = naptien.MaTK;
                    nt.NgayNap = DateTime.Today;
                    nt.SoTienNap = Convert.ToInt32(txtNapTien.Text);

                    db.NapTiens.AddOrUpdate(nt);
                    db.SuDungs.AddOrUpdate(naptien);
                    db.SaveChanges();

                    txtNapTien.Clear();
                    loadDGV();

                    MessageBox.Show($"Nạp tiền {naptien.SoMay} thành công!", "Thông báo");
                    dgvDSPM.Rows[0].Selected = false;
                    if (CheckID(naptien.SoMay) != -1)
                        dgvDSPM.Rows[CheckID(naptien.SoMay)].Selected = true;
                }
                else
                    MessageBox.Show($"Nạp tiền {txtTimMay.Text} thất bại!", "Thông báo");
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGioiThieu form = new FormGioiThieu();
            form.FormClosed += new FormClosedEventHandler(form_FormClosed);
            form.Show();
            this.Hide();
        }

        private void dgvDSPM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtTimMay_Click(object sender, EventArgs e)
        {
            txtTimMay.Clear();
        }
    }
}
