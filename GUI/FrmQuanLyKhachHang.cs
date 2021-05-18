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
    public partial class FrmQuanLyKhachHang : Form
    {
        public FrmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void FrmQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachKhachHang();
        }

        private void LoadDanhSachKhachHang()
        {
            try
            {
                dgvKhachHang.Rows.Clear();
                int index;
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (KhachHang khachHang in _dbContext.KhachHangs.Where(a => a.Status == 1))
                    {
                        index = dgvKhachHang.Rows.Add();
                        dgvKhachHang.Rows[index].Cells[0].Value = khachHang.MaKH;
                        dgvKhachHang.Rows[index].Cells[1].Value = khachHang.TenKH;
                        dgvKhachHang.Rows[index].Cells[2].Value = khachHang.SDT;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "" || txtSDT.Text == "" || txtTenKH.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin!!");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    KhachHang khachHang = _dbContext.KhachHangs.FirstOrDefault(a => a.MaKH == txtMaKH.Text);
                    if (khachHang != null && khachHang.Status == 1)
                    {
                        khachHang.SDT = txtSDT.Text;
                        khachHang.TenKH = txtTenKH.Text;

                        MessageBox.Show("Sửa thành công");
                    }
                    else if (khachHang != null && khachHang.Status == 0)
                        throw new Exception("Vui lòng chọn mã khách hàng khác");
                    else
                    {
                        khachHang = new KhachHang();
                        khachHang.MaKH = txtMaKH.Text;
                        khachHang.SDT = txtSDT.Text;
                        khachHang.TenKH = txtTenKH.Text;
                        khachHang.Status = 1;

                        TaiKhoanKH tk = new TaiKhoanKH();
                        tk.MaKH = khachHang.MaKH;
                        tk.MK = khachHang.MaKH;

                        _dbContext.TaiKhoanKHs.Add(tk);
                        _dbContext.KhachHangs.Add(khachHang);

                        MessageBox.Show("Thêm khách hàng thành công");
                    }
                    _dbContext.SaveChanges();

                    LoadDanhSachKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKH.Text == "" || txtSDT.Text == "" || txtTenKH.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin!!");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    KhachHang khachHang = _dbContext.KhachHangs.FirstOrDefault(a => a.MaKH == txtMaKH.Text);
                    if (khachHang != null)
                    {
                        khachHang.Status = 0;

                        TaiKhoanKH tk = _dbContext.TaiKhoanKHs.FirstOrDefault(a => a.MaKH == khachHang.MaKH);
                        if (tk != null)
                            _dbContext.TaiKhoanKHs.Remove(tk);
                    }
                    else
                        MessageBox.Show("Không tìm thấy thông tin khách hàng");
                    _dbContext.SaveChanges();

                    LoadDanhSachKhachHang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
