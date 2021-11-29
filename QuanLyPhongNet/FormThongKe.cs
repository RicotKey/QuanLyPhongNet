using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyPhongNet.Model;
namespace QuanLyPhongNet
{
    public partial class FormThongKe : Form
    {
        DoAnContextDB db = new DoAnContextDB();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {

            reportViewer1.Visible = false;

            rdNgay.Checked = true;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = true;
            List<ReportDoAn> reportDoAns = new List<ReportDoAn>();
            if (rdNgay.Checked == true)
            {
                List<NapTien> napTiens = db.NapTiens.Where(p=> p.NgayNap.Value.Day == dtNgay.Value.Day && p.NgayNap.Value.Month == dtNgay.Value.Month && p.NgayNap.Value.Year == dtNgay.Value.Year).ToList();
                foreach (var item in napTiens)
                {
                    ReportDoAn rpDoAn = new ReportDoAn();
                    rpDoAn.MaNapTien = item.MaNapTien;
                    rpDoAn.TenTK = item.TaiKhoan.TenTK;
                    rpDoAn.NgayNap = item.NgayNap;
                    rpDoAn.SoTienNap = item.SoTienNap;
                    reportDoAns.Add(rpDoAn);
                }
                ReportParameter[] para = new ReportParameter[2];
                para[0] = new ReportParameter("Day", dtNgay.Value.ToString("dd/MM/yyyy"));
                para[1] = new ReportParameter("NumTK", "Theo ngày");
                this.reportViewer1.LocalReport.ReportPath = "./Report/Report1.rdlc";
                var reportDtaSource = new ReportDataSource("DataSetThongKe", reportDoAns);
                this.reportViewer1.LocalReport.SetParameters(para);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDtaSource);
                this.reportViewer1.RefreshReport();
            }   
            if(rdThang.Checked == true)
            {
                List<NapTien> napTiens = db.NapTiens.Where(p => p.NgayNap.Value.Month == dtThang.Value.Month && p.NgayNap.Value.Year == dtThang.Value.Year).ToList();
                foreach (var item in napTiens)
                {
                    ReportDoAn rpDoAn = new ReportDoAn();
                    rpDoAn.MaNapTien = item.MaNapTien;
                    rpDoAn.TenTK = item.TaiKhoan.TenTK;
                    rpDoAn.NgayNap = item.NgayNap;
                    rpDoAn.SoTienNap = item.SoTienNap;
                    reportDoAns.Add(rpDoAn);
                }
                ReportParameter[] para = new ReportParameter[2];
                para[0] = new ReportParameter("Day", dtThang.Value.ToString("MM/yyyy"));
                para[1] = new ReportParameter("NumTK", "Theo tháng");
                this.reportViewer1.LocalReport.ReportPath = "./Report/Report1.rdlc";
                var reportDtaSource = new ReportDataSource("DataSetThongKe", reportDoAns);
                this.reportViewer1.LocalReport.SetParameters(para);

                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDtaSource);
                this.reportViewer1.RefreshReport();
            }    
        }
    }
}
