
namespace QuanLyQuanAn.GUI
{
    partial class FrmLichSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLichSu));
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpXemTheoNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.rdoXemTheoNgay = new System.Windows.Forms.RadioButton();
            this.rdoXemTheoThang = new System.Windows.Forms.RadioButton();
            this.rdoXemTheoNam = new System.Windows.Forms.RadioButton();
            this.rdoXemTatCa = new System.Windows.Forms.RadioButton();
            this.rdTuNgay = new System.Windows.Forms.RadioButton();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AllowUserToAddRows = false;
            this.dgvLichSu.AllowUserToDeleteRows = false;
            this.dgvLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvLichSu.Location = new System.Drawing.Point(12, 123);
            this.dgvLichSu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.ReadOnly = true;
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.RowTemplate.Height = 24;
            this.dgvLichSu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichSu.Size = new System.Drawing.Size(981, 618);
            this.dgvLichSu.TabIndex = 0;
            this.dgvLichSu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichSu_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tổng tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nhân viên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xem theo ngày";
            // 
            // dtpXemTheoNgay
            // 
            this.dtpXemTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpXemTheoNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpXemTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpXemTheoNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpXemTheoNgay.Location = new System.Drawing.Point(196, 47);
            this.dtpXemTheoNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpXemTheoNgay.Name = "dtpXemTheoNgay";
            this.dtpXemTheoNgay.Size = new System.Drawing.Size(173, 30);
            this.dtpXemTheoNgay.TabIndex = 2;
            this.dtpXemTheoNgay.ValueChanged += new System.EventHandler(this.dtpXemTheoNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(645, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.Location = new System.Drawing.Point(751, 49);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(241, 30);
            this.txtTongTien.TabIndex = 4;
            // 
            // rdoXemTheoNgay
            // 
            this.rdoXemTheoNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoXemTheoNgay.AutoSize = true;
            this.rdoXemTheoNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoXemTheoNgay.Location = new System.Drawing.Point(248, 12);
            this.rdoXemTheoNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoXemTheoNgay.Name = "rdoXemTheoNgay";
            this.rdoXemTheoNgay.Size = new System.Drawing.Size(165, 29);
            this.rdoXemTheoNgay.TabIndex = 5;
            this.rdoXemTheoNgay.Text = "Xem theo ngày";
            this.rdoXemTheoNgay.UseVisualStyleBackColor = true;
            this.rdoXemTheoNgay.Click += new System.EventHandler(this.rdo_Change);
            // 
            // rdoXemTheoThang
            // 
            this.rdoXemTheoThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoXemTheoThang.AutoSize = true;
            this.rdoXemTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoXemTheoThang.Location = new System.Drawing.Point(448, 12);
            this.rdoXemTheoThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoXemTheoThang.Name = "rdoXemTheoThang";
            this.rdoXemTheoThang.Size = new System.Drawing.Size(171, 29);
            this.rdoXemTheoThang.TabIndex = 5;
            this.rdoXemTheoThang.Text = "Xem theo tháng";
            this.rdoXemTheoThang.UseVisualStyleBackColor = true;
            this.rdoXemTheoThang.Click += new System.EventHandler(this.rdo_Change);
            // 
            // rdoXemTheoNam
            // 
            this.rdoXemTheoNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoXemTheoNam.AutoSize = true;
            this.rdoXemTheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoXemTheoNam.Location = new System.Drawing.Point(665, 12);
            this.rdoXemTheoNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoXemTheoNam.Name = "rdoXemTheoNam";
            this.rdoXemTheoNam.Size = new System.Drawing.Size(160, 29);
            this.rdoXemTheoNam.TabIndex = 5;
            this.rdoXemTheoNam.Text = "Xem theo năm";
            this.rdoXemTheoNam.UseVisualStyleBackColor = true;
            this.rdoXemTheoNam.Click += new System.EventHandler(this.rdo_Change);
            // 
            // rdoXemTatCa
            // 
            this.rdoXemTatCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoXemTatCa.AutoSize = true;
            this.rdoXemTatCa.Checked = true;
            this.rdoXemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdoXemTatCa.Location = new System.Drawing.Point(89, 12);
            this.rdoXemTatCa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoXemTatCa.Name = "rdoXemTatCa";
            this.rdoXemTatCa.Size = new System.Drawing.Size(126, 29);
            this.rdoXemTatCa.TabIndex = 5;
            this.rdoXemTatCa.TabStop = true;
            this.rdoXemTatCa.Text = "Xem tất cả";
            this.rdoXemTatCa.UseVisualStyleBackColor = true;
            this.rdoXemTatCa.Click += new System.EventHandler(this.rdo_Change);
            // 
            // rdTuNgay
            // 
            this.rdTuNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdTuNgay.AutoSize = true;
            this.rdTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdTuNgay.Location = new System.Drawing.Point(849, 12);
            this.rdTuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTuNgay.Name = "rdTuNgay";
            this.rdTuNgay.Size = new System.Drawing.Size(143, 29);
            this.rdTuNgay.TabIndex = 5;
            this.rdTuNgay.Text = "Xem từ ngày";
            this.rdTuNgay.UseVisualStyleBackColor = true;
            this.rdTuNgay.Click += new System.EventHandler(this.rdo_Change);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Enabled = false;
            this.dtpDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(446, 47);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(173, 30);
            this.dtpDenNgay.TabIndex = 2;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(526, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tìm kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(632, 85);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(241, 30);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.Text = "Nhập hóa đơn";
            this.txtTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            this.txtTimKiem.Validated += new System.EventHandler(this.txtTimKiem_Validated);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(879, 83);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(113, 32);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // FrmLichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1005, 750);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.rdTuNgay);
            this.Controls.Add(this.rdoXemTheoNam);
            this.Controls.Add(this.rdoXemTheoThang);
            this.Controls.Add(this.rdoXemTatCa);
            this.Controls.Add(this.rdoXemTheoNgay);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dtpDenNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpXemTheoNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLichSu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLichSu";
            this.Text = "Xem lịch sử hóa đơn";
            this.Load += new System.EventHandler(this.FrmLichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpXemTheoNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.RadioButton rdoXemTheoNgay;
        private System.Windows.Forms.RadioButton rdoXemTheoThang;
        private System.Windows.Forms.RadioButton rdoXemTheoNam;
        private System.Windows.Forms.RadioButton rdoXemTatCa;
        private System.Windows.Forms.RadioButton rdTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}