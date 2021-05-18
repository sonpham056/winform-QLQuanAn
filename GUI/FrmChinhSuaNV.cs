using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Model;

namespace QuanLyQuanAn.GUI
{
    public partial class FrmChinhSuaNV : Form
    {
        public FrmChinhSuaNV()
        {
            InitializeComponent();
        }

        private void FrmChinhSuaNV_Load(object sender, EventArgs e)
        {
            LoadCmb();
            LoadDanhSachNV();
            DemNV();
        }

        private void LoadCmb()
        {
            for (int i = 1; i <= 31; i++)
            {
                cmbNgaySinh.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                if (i < 10)
                    cmbThang.Items.Add("0" + i);
                else
                    cmbThang.Items.Add(i);
            }
            for (int i = 2021; i >= 1970; i--)
            {
                cmbNam.Items.Add(i);
            }
            cmbNam.SelectedIndex = 0;
            cmbNgaySinh.SelectedIndex = 0;
            cmbThang.SelectedIndex = 0;
        }

        private void LoadDanhSachNV()
        {
            int index;
            dgvNhanVien.Rows.Clear();
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (NhanVien nhanVien in _dbContext.NhanViens.Where(a => a.Status == 1).ToList())
                {
                    if (nhanVien.MaNV == "admin")
                        continue;
                    index = dgvNhanVien.Rows.Add();
                    dgvNhanVien.Rows[index].Cells[0].Value = nhanVien.MaNV;
                    dgvNhanVien.Rows[index].Cells[1].Value = nhanVien.TenNV;
                    dgvNhanVien.Rows[index].Cells[2].Value = nhanVien.NgaySinh.Value.ToString("dd/MM/yyyy");
                    dgvNhanVien.Rows[index].Cells[3].Value = nhanVien.GioiTinh;
                    dgvNhanVien.Rows[index].Cells[4].Value = nhanVien.SDT;
                }
            }
        }

        private void dgvNhanVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                string str = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();
                string[] temp = str.Split(SlashOrMinus(str));
                cmbNgaySinh.Text = temp[0];
                cmbThang.Text = temp[1];
                cmbNam.Text = temp[2];
                rdoNam.Checked = (dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString() == "Nam") ? true : false;
                rdoNu.Checked = (rdoNam.Checked == true) ? false : true;
                txtSDT.Text = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

        }

        private char SlashOrMinus(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '/')
                    return '/';
            }
            return '-';
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtSDT.Text == "" || txtTenNV.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    NhanVien nhanVien = _dbContext.NhanViens.FirstOrDefault(a => a.MaNV == txtMaNV.Text);
                    if (nhanVien != null && nhanVien.Status == 1)
                    {
                        nhanVien.TenNV = txtTenNV.Text;
                        nhanVien.SDT = txtSDT.Text;
                        nhanVien.GioiTinh = (rdoNam.Checked == true) ? "Nam" : "Nữ";
                        nhanVien.NgaySinh = DateTime.Parse(cmbNgaySinh.Text + "-" + cmbThang.Text + "-" + cmbNam.Text);

                        _dbContext.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else if (nhanVien != null && nhanVien.Status != 1)
                        throw new Exception("Vui lọng chọn mã nhân viên khác");
                    else
                    {
                        nhanVien = new NhanVien();
                        nhanVien.GioiTinh = nhanVien.GioiTinh = (rdoNam.Checked == true) ? "Nam" : "Nữ";
                        nhanVien.NgaySinh = DateTime.Parse(cmbNgaySinh.Text + "-" + cmbThang.Text + "-" + cmbNam.Text);
                        nhanVien.TenNV = txtTenNV.Text;
                        nhanVien.SDT = txtSDT.Text;
                        nhanVien.MaNV = txtMaNV.Text;
                        nhanVien.Status = 1;

                        TaiKhoanNV taiKhoan = new TaiKhoanNV();
                        taiKhoan.MaNV = txtMaNV.Text;
                        taiKhoan.MK = txtMaNV.Text;

                        _dbContext.NhanViens.Add(nhanVien);
                        _dbContext.TaiKhoanNVs.Add(taiKhoan);
                        _dbContext.SaveChanges();

                        MessageBox.Show("Thêm nhân viên thành công!");
                    }
                }
                LoadDanhSachNV();
                DemNV();
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
                if (txtMaNV.Text == "")
                    throw new Exception("Vui lòng nhập mã nhân viên cần xóa");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    NhanVien nhanVien = _dbContext.NhanViens.FirstOrDefault(a => a.MaNV == txtMaNV.Text);
                    if (nhanVien != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa nhân viên: " + nhanVien.TenNV + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            TaiKhoanNV taiKhoan = _dbContext.TaiKhoanNVs.FirstOrDefault(a => a.MaNV == txtMaNV.Text);
                            if (taiKhoan != null)
                                _dbContext.TaiKhoanNVs.Remove(taiKhoan);
                            nhanVien.Status = 0;
                            _dbContext.SaveChanges();
                        }
                    }
                }
                LoadDanhSachNV();
                DemNV();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtTenNV.Text = "";
            rdoNam.Checked = true;
            rdoNu.Checked = false;
            cmbNam.SelectedIndex = 0;
            cmbNgaySinh.SelectedIndex = 0;
            cmbThang.SelectedIndex = 0;
        }

        private void DemNV()
        {
            txtSoNV.Text = dgvNhanVien.RowCount.ToString();
        }
    }
}
