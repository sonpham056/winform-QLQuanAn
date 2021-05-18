
namespace QuanLyQuanAn.GUI
{
    partial class FrmReportTongKetHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportTongKetHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXuat = new System.Windows.Forms.Button();
            this.rdXemTuNgay = new System.Windows.Forms.RadioButton();
            this.rdXemTheoThang = new System.Windows.Forms.RadioButton();
            this.rdXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpXemTheoThang = new System.Windows.Forms.DateTimePicker();
            this.dtpXemTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.food;
            this.panel1.Controls.Add(this.btnXuat);
            this.panel1.Controls.Add(this.rdXemTuNgay);
            this.panel1.Controls.Add(this.rdXemTheoThang);
            this.panel1.Controls.Add(this.rdXemTheoNgay);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.dtpXemTheoThang);
            this.panel1.Controls.Add(this.dtpXemTheoNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 156);
            this.panel1.TabIndex = 1;
            // 
            // btnXuat
            // 
            this.btnXuat.AutoSize = true;
            this.btnXuat.Location = new System.Drawing.Point(529, 117);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(82, 23);
            this.btnXuat.TabIndex = 3;
            this.btnXuat.Text = "Xuất hóa đơn";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // rdXemTuNgay
            // 
            this.rdXemTuNgay.AutoSize = true;
            this.rdXemTuNgay.Location = new System.Drawing.Point(146, 124);
            this.rdXemTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdXemTuNgay.Name = "rdXemTuNgay";
            this.rdXemTuNgay.Size = new System.Drawing.Size(84, 17);
            this.rdXemTuNgay.TabIndex = 2;
            this.rdXemTuNgay.Text = "Xem từ ngày";
            this.rdXemTuNgay.UseVisualStyleBackColor = true;
            this.rdXemTuNgay.CheckedChanged += new System.EventHandler(this.Check_changed);
            // 
            // rdXemTheoThang
            // 
            this.rdXemTheoThang.AutoSize = true;
            this.rdXemTheoThang.Location = new System.Drawing.Point(146, 77);
            this.rdXemTheoThang.Margin = new System.Windows.Forms.Padding(2);
            this.rdXemTheoThang.Name = "rdXemTheoThang";
            this.rdXemTheoThang.Size = new System.Drawing.Size(100, 17);
            this.rdXemTheoThang.TabIndex = 2;
            this.rdXemTheoThang.Text = "Xem theo tháng";
            this.rdXemTheoThang.UseVisualStyleBackColor = true;
            this.rdXemTheoThang.CheckedChanged += new System.EventHandler(this.Check_changed);
            // 
            // rdXemTheoNgay
            // 
            this.rdXemTheoNgay.AutoSize = true;
            this.rdXemTheoNgay.Checked = true;
            this.rdXemTheoNgay.Location = new System.Drawing.Point(146, 29);
            this.rdXemTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.rdXemTheoNgay.Name = "rdXemTheoNgay";
            this.rdXemTheoNgay.Size = new System.Drawing.Size(96, 17);
            this.rdXemTheoNgay.TabIndex = 2;
            this.rdXemTheoNgay.TabStop = true;
            this.rdXemTheoNgay.Text = "Xem theo ngày";
            this.rdXemTheoNgay.UseVisualStyleBackColor = true;
            this.rdXemTheoNgay.CheckedChanged += new System.EventHandler(this.Check_changed);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(386, 121);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(113, 20);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Enabled = false;
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(253, 121);
            this.dtpTuNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(113, 20);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // dtpXemTheoThang
            // 
            this.dtpXemTheoThang.CustomFormat = "dd/MM/yyyy";
            this.dtpXemTheoThang.Enabled = false;
            this.dtpXemTheoThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXemTheoThang.Location = new System.Drawing.Point(253, 75);
            this.dtpXemTheoThang.Margin = new System.Windows.Forms.Padding(2);
            this.dtpXemTheoThang.Name = "dtpXemTheoThang";
            this.dtpXemTheoThang.Size = new System.Drawing.Size(113, 20);
            this.dtpXemTheoThang.TabIndex = 1;
            // 
            // dtpXemTheoNgay
            // 
            this.dtpXemTheoNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpXemTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXemTheoNgay.Location = new System.Drawing.Point(253, 27);
            this.dtpXemTheoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpXemTheoNgay.Name = "dtpXemTheoNgay";
            this.dtpXemTheoNgay.Size = new System.Drawing.Size(113, 20);
            this.dtpXemTheoNgay.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.food;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.rptViewer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 385);
            this.panel2.TabIndex = 2;
            // 
            // rptViewer
            // 
            this.rptViewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewer.Location = new System.Drawing.Point(0, 0);
            this.rptViewer.Margin = new System.Windows.Forms.Padding(2);
            this.rptViewer.Name = "rptViewer";
            this.rptViewer.ServerReport.BearerToken = null;
            this.rptViewer.Size = new System.Drawing.Size(792, 385);
            this.rptViewer.TabIndex = 0;
            this.rptViewer.Visible = false;
            // 
            // FrmReportTongKetHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanAn.Properties.Resources.food;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReportTongKetHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.FrmReportTongKetHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rptViewer;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpXemTheoThang;
        private System.Windows.Forms.DateTimePicker dtpXemTheoNgay;
        private System.Windows.Forms.RadioButton rdXemTuNgay;
        private System.Windows.Forms.RadioButton rdXemTheoThang;
        private System.Windows.Forms.RadioButton rdXemTheoNgay;
        private System.Windows.Forms.Button btnXuat;
    }
}