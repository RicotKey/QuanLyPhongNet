
namespace QuanLyPhongNet
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtThang = new System.Windows.Forms.DateTimePicker();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.rdThang = new System.Windows.Forms.RadioButton();
            this.rdNgay = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtThang);
            this.groupBox1.Controls.Add(this.dtNgay);
            this.groupBox1.Controls.Add(this.rdThang);
            this.groupBox1.Controls.Add(this.rdNgay);
            this.groupBox1.Location = new System.Drawing.Point(168, 12);
            this.groupBox1.MinimumSize = new System.Drawing.Size(583, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtThang
            // 
            this.dtThang.CustomFormat = "MM/yyyy";
            this.dtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtThang.Location = new System.Drawing.Point(241, 64);
            this.dtThang.Name = "dtThang";
            this.dtThang.Size = new System.Drawing.Size(94, 20);
            this.dtThang.TabIndex = 3;
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(241, 24);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(151, 20);
            this.dtNgay.TabIndex = 1;
            // 
            // rdThang
            // 
            this.rdThang.AutoSize = true;
            this.rdThang.Location = new System.Drawing.Point(29, 68);
            this.rdThang.Name = "rdThang";
            this.rdThang.Size = new System.Drawing.Size(146, 17);
            this.rdThang.TabIndex = 2;
            this.rdThang.TabStop = true;
            this.rdThang.Text = "Xuất thống kê theo tháng";
            this.rdThang.UseVisualStyleBackColor = true;
            // 
            // rdNgay
            // 
            this.rdNgay.AutoSize = true;
            this.rdNgay.Location = new System.Drawing.Point(29, 28);
            this.rdNgay.Name = "rdNgay";
            this.rdNgay.Size = new System.Drawing.Size(146, 17);
            this.rdNgay.TabIndex = 0;
            this.rdNgay.TabStop = true;
            this.rdNgay.Text = "Xuất Thống kê theo ngày";
            this.rdNgay.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(399, 118);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(137, 34);
            this.btnThongKe.TabIndex = 0;
            this.btnThongKe.Text = "Xuất Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.DocumentMapWidth = 10;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongNet.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 161);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(910, 488);
            this.reportViewer1.TabIndex = 1;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.RadioButton rdThang;
        private System.Windows.Forms.RadioButton rdNgay;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.DateTimePicker dtThang;
    }
}