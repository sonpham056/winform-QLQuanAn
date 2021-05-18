using QuanLyQuanAn.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.GUI
{
    public partial class FrmQuanLyMatKhau : Form
    {
        public FrmQuanLyMatKhau()
        {
            InitializeComponent();
        }

        private void FrmQuanLyMatKhau_Load(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoanNV();
        }

        private void LoadDanhSachTaiKhoanNV()
        {
            dgvMatKhau.Rows.Clear();
            int index;
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (TaiKhoanNV taiKhoan in _dbContext.TaiKhoanNVs.ToList())
                {
                    if (taiKhoan.MaNV == "admin")
                        continue;
                    index = dgvMatKhau.Rows.Add();
                    dgvMatKhau.Rows[index].Cells[0].Value = taiKhoan.MaNV;
                    dgvMatKhau.Rows[index].Cells[1].Value = taiKhoan.MK;
                }
            }
        }

        private void dgvMatKhau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTaiKhoan.Text =  dgvMatKhau.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMatKhau.Text = dgvMatKhau.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnDoiMatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhau.Text == "" || txtTaiKhoan.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin!!");
                if (txtTaiKhoan.Text == "admin")
                    throw new Exception("Vui lòng dùng chức năng đổi mật khẩu của admin");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    TaiKhoanNV taiKhoan = _dbContext.TaiKhoanNVs.FirstOrDefault(a => a.MaNV == txtTaiKhoan.Text);
                    if (taiKhoan != null)
                    {
                        taiKhoan.MK = txtMatKhau.Text;

                        _dbContext.SaveChanges();
                        MessageBox.Show("Cập nhật mật khẩu cho nhân viên: " + taiKhoan.NhanVien.TenNV + " thành công");
                    }
                    else
                        MessageBox.Show("Không tìm thấy tài khoản");
                    LoadDanhSachTaiKhoanNV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
