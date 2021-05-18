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
    public partial class FrmChinhSuaMonAn : Form
    {
        public FrmChinhSuaMonAn()
        {
            InitializeComponent();
        }

        private void FrmChinhSuaMonAn_Load(object sender, EventArgs e)
        {
            LoadDanhSachMonAn();
            LoadCmbLoaiMonAn();
        }

        private void LoadCmbLoaiMonAn()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                cmbLoaiMonAn.DataSource = _dbContext.LoaiMonAns.ToList();
                cmbLoaiMonAn.DisplayMember = "Loai";
                cmbLoaiMonAn.ValueMember = "MaLoaiMonAn";
            }
        }

        private void LoadDanhSachMonAn()
        {
            try
            {
                dgvMonAn.Rows.Clear();
                int index;
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (MonAn monAn in _dbContext.MonAns.Where(a => a.Status == 1).ToList())
                    {
                        index = dgvMonAn.Rows.Add();
                        dgvMonAn.Rows[index].Cells[0].Value = monAn.MaMA;
                        dgvMonAn.Rows[index].Cells[1].Value = monAn.TenMA;
                        dgvMonAn.Rows[index].Cells[2].Value = monAn.GiaTien;
                        dgvMonAn.Rows[index].Cells[3].Value = monAn.LoaiMonAn.Loai;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMonAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMaMA.Text = dgvMonAn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenMA.Text = dgvMonAn.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGiaTien.Text = dgvMonAn.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbLoaiMonAn.Text = dgvMonAn.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMA.Text == "" || txtTenMA.Text == "" || txtGiaTien.Text == "" || cmbLoaiMonAn.Text == "")
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    MonAn monAn = _dbContext.MonAns.FirstOrDefault(a => a.MaMA == txtMaMA.Text);
                    if (monAn != null && monAn.Status == 1) //status bằng 1 thì sửa bằng 0 thì thông báo vui lòng chọn mã món ăn khác
                    {
                        monAn.TenMA = txtTenMA.Text;
                        monAn.GiaTien = int.Parse(txtGiaTien.Text);
                        monAn.MaLoaiMonAn = cmbLoaiMonAn.SelectedValue.ToString();
                        _dbContext.SaveChanges();

                        MessageBox.Show("Sửa món ăn thành công!");
                    }
                    else if (monAn != null && monAn.Status == 0)
                    {
                        throw new Exception("Vui lòng chộn mã món ăn khác!");
                    }
                    else
                    {
                        monAn = new MonAn();
                        monAn.MaMA = txtMaMA.Text;
                        monAn.TenMA = txtTenMA.Text;
                        monAn.GiaTien = int.Parse(txtGiaTien.Text);
                        monAn.MaLoaiMonAn = cmbLoaiMonAn.SelectedValue.ToString();
                        monAn.Status = 1;

                        _dbContext.MonAns.Add(monAn);
                        _dbContext.SaveChanges();
                    }
                }
                LoadDanhSachMonAn();
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
                if (txtMaMA.Text == "")
                    throw new Exception("Vui lòng nhập mã món ăn cần xóa");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    MonAn monAn = _dbContext.MonAns.FirstOrDefault(a => a.MaMA == txtMaMA.Text);
                    if (monAn != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            monAn.Status = 0;
                            _dbContext.SaveChanges();
                            btnReset_Click(sender, e);
                        }
                    }
                    else
                        MessageBox.Show("Không tìm thấy món ăn");
                }
                LoadDanhSachMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtGiaTien_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(txtGiaTien.Text, out _) == false)
            {
                errorProvider1.SetError(txtGiaTien, "Vui lòng nhập số");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGiaTien.Text = "";
            txtMaMA.Text = "";
            txtTenMA.Text = "";
            cmbLoaiMonAn.Text = "";
        }
    }
}
