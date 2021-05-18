
namespace QuanLyQuanAn.GUI
{
    partial class FrmQuanLyMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatKhau = new System.Windows.Forms.DataGridView();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoiMatkhau = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatKhau)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // dgvMatKhau
            // 
            this.dgvMatKhau.AllowUserToAddRows = false;
            this.dgvMatKhau.AllowUserToDeleteRows = false;
            this.dgvMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatKhau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatKhau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatKhau.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taikhoan,
            this.Column1});
            this.dgvMatKhau.Location = new System.Drawing.Point(499, 12);
            this.dgvMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMatKhau.Name = "dgvMatKhau";
            this.dgvMatKhau.ReadOnly = true;
            this.dgvMatKhau.RowHeadersWidth = 51;
            this.dgvMatKhau.RowTemplate.Height = 24;
            this.dgvMatKhau.Size = new System.Drawing.Size(496, 409);
            this.dgvMatKhau.TabIndex = 1;
            this.dgvMatKhau.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatKhau_CellClick);
            // 
            // taikhoan
            // 
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.MinimumWidth = 6;
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mật khẩu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoiMatkhau);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTaiKhoan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(480, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý mật khẩu";
            // 
            // btnDoiMatkhau
            // 
            this.btnDoiMatkhau.AutoSize = true;
            this.btnDoiMatkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDoiMatkhau.Location = new System.Drawing.Point(143, 213);
            this.btnDoiMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoiMatkhau.Name = "btnDoiMatkhau";
            this.btnDoiMatkhau.Size = new System.Drawing.Size(181, 43);
            this.btnDoiMatkhau.TabIndex = 2;
            this.btnDoiMatkhau.Text = "Đổi mật khẩu";
            this.btnDoiMatkhau.UseVisualStyleBackColor = false;
            this.btnDoiMatkhau.Click += new System.EventHandler(this.btnDoiMatkhau_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(143, 114);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(245, 30);
            this.txtMatKhau.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(143, 74);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(245, 30);
            this.txtTaiKhoan.TabIndex = 0;
            // 
            // FrmQuanLyMatKhau
            // 
            this.AcceptButton = this.btnDoiMatkhau;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1005, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuanLyMatKhau";
            this.Text = "Quản lý mật khẩu";
            this.Load += new System.EventHandler(this.FrmQuanLyMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatKhau)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatKhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoiMatkhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}