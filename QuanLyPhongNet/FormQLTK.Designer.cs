
namespace QuanLyPhongNet
{
    partial class FormQLTK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLTK));
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.dgvTenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThoiGianConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimTK = new System.Windows.Forms.TextBox();
            this.btnNap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNapTien = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboMayOff = new System.Windows.Forms.ComboBox();
            this.btnMoMay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSTK
            // 
            this.dgvDSTK.AllowUserToAddRows = false;
            this.dgvDSTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTenTK,
            this.dgvSoTien,
            this.dgvThoiGianConLai,
            this.dgvTrangThai});
            this.dgvDSTK.Location = new System.Drawing.Point(10, 138);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.Size = new System.Drawing.Size(776, 321);
            this.dgvDSTK.TabIndex = 0;
            this.dgvDSTK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellClick);
            this.dgvDSTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSTK_CellContentClick);
            // 
            // dgvTenTK
            // 
            this.dgvTenTK.HeaderText = "Tên Tài Khoản";
            this.dgvTenTK.Name = "dgvTenTK";
            // 
            // dgvSoTien
            // 
            this.dgvSoTien.HeaderText = "Tiền";
            this.dgvSoTien.Name = "dgvSoTien";
            // 
            // dgvThoiGianConLai
            // 
            this.dgvThoiGianConLai.HeaderText = "Thời gian còn lại";
            this.dgvThoiGianConLai.Name = "dgvThoiGianConLai";
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.HeaderText = "Trạng Thái";
            this.dgvTrangThai.Name = "dgvTrangThai";
            // 
            // btnTimTK
            // 
            this.btnTimTK.Location = new System.Drawing.Point(137, 80);
            this.btnTimTK.Name = "btnTimTK";
            this.btnTimTK.Size = new System.Drawing.Size(75, 23);
            this.btnTimTK.TabIndex = 1;
            this.btnTimTK.Text = "Tìm Kiếm";
            this.btnTimTK.UseVisualStyleBackColor = true;
            this.btnTimTK.Click += new System.EventHandler(this.btnTimTK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // txtTimTK
            // 
            this.txtTimTK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTimTK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTK.ForeColor = System.Drawing.Color.Red;
            this.txtTimTK.Location = new System.Drawing.Point(10, 81);
            this.txtTimTK.Name = "txtTimTK";
            this.txtTimTK.Size = new System.Drawing.Size(121, 22);
            this.txtTimTK.TabIndex = 0;
            this.txtTimTK.Text = "TÀI KHOẢN";
            this.txtTimTK.Click += new System.EventHandler(this.txtTimTK_Click);
            // 
            // btnNap
            // 
            this.btnNap.Location = new System.Drawing.Point(137, 111);
            this.btnNap.Name = "btnNap";
            this.btnNap.Size = new System.Drawing.Size(75, 23);
            this.btnNap.TabIndex = 3;
            this.btnNap.Text = "Nạp";
            this.btnNap.UseVisualStyleBackColor = true;
            this.btnNap.Click += new System.EventHandler(this.btnNap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // txtNapTien
            // 
            this.txtNapTien.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNapTien.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNapTien.ForeColor = System.Drawing.Color.Red;
            this.txtNapTien.Location = new System.Drawing.Point(10, 110);
            this.txtNapTien.Name = "txtNapTien";
            this.txtNapTien.Size = new System.Drawing.Size(121, 23);
            this.txtNapTien.TabIndex = 2;
            this.txtNapTien.Text = "NẠP TIỀN";
            this.txtNapTien.Click += new System.EventHandler(this.txtNapTien_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(798, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QuanLyPhongNet.Properties.Resources._831_8314404_png_file_svg_admin_report_icon;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::QuanLyPhongNet.Properties.Resources.Circle_icons_computer_svg;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::QuanLyPhongNet.Properties.Resources._220_2203468_exit_png_image_exit_png_transparent_png;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.BackgroundImage = global::QuanLyPhongNet.Properties.Resources._7142ed6fbfa1b129570e2dc3166aecb5_32bits_48;
            this.btnTaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.Location = new System.Drawing.Point(618, 80);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(168, 24);
            this.btnTaoTK.TabIndex = 6;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = true;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(711, 462);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(253, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cboMayOff
            // 
            this.cboMayOff.FormattingEnabled = true;
            this.cboMayOff.Location = new System.Drawing.Point(618, 112);
            this.cboMayOff.Name = "cboMayOff";
            this.cboMayOff.Size = new System.Drawing.Size(87, 21);
            this.cboMayOff.TabIndex = 4;
            // 
            // btnMoMay
            // 
            this.btnMoMay.Location = new System.Drawing.Point(711, 110);
            this.btnMoMay.Name = "btnMoMay";
            this.btnMoMay.Size = new System.Drawing.Size(75, 23);
            this.btnMoMay.TabIndex = 5;
            this.btnMoMay.Text = "Mở máy";
            this.btnMoMay.UseVisualStyleBackColor = true;
            this.btnMoMay.Click += new System.EventHandler(this.btnMoMay_Click);
            // 
            // FormQLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(798, 489);
            this.Controls.Add(this.btnMoMay);
            this.Controls.Add(this.cboMayOff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtNapTien);
            this.Controls.Add(this.txtTimTK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.btnNap);
            this.Controls.Add(this.btnTimTK);
            this.Controls.Add(this.dgvDSTK);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQLTK";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.FormQLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.Button btnTimTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimTK;
        private System.Windows.Forms.Button btnNap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNapTien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThoiGianConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnMoMay;
        private System.Windows.Forms.ComboBox cboMayOff;
    }
}