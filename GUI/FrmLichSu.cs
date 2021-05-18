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
    public partial class FrmLichSu : Form
    {
        public FrmLichSu()
        {
            InitializeComponent();
        }

        private void FrmLichSu_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void LoadDanhSachHoaDon()
        {
            try
            {
                if (rdoXemTatCa.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    dgvLichSu.Rows.Clear();
                    int index;
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            index = dgvLichSu.Rows.Add();
                            dgvLichSu.Rows[index].Cells[0].Value = hoaDon.MaHD;
                            dgvLichSu.Rows[index].Cells[1].Value = hoaDon.NgayLap;
                            dgvLichSu.Rows[index].Cells[2].Value = hoaDon.TongTien;
                            dgvLichSu.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                            dgvLichSu.Rows[index].Cells[4].Value = hoaDon.ThanhToan;
                        }
                    }

                    txtTongTien.Text = TinhTien().ToString();
                }
                else if (rdoXemTheoNam.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    dgvLichSu.Rows.Clear();
                    int index;
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.ToString("yyyy") == dtpXemTheoNgay.Value.ToString("yyyy"))
                            {
                                index = dgvLichSu.Rows.Add();
                                dgvLichSu.Rows[index].Cells[0].Value = hoaDon.MaHD;
                                dgvLichSu.Rows[index].Cells[1].Value = hoaDon.NgayLap;
                                dgvLichSu.Rows[index].Cells[2].Value = hoaDon.TongTien;
                                dgvLichSu.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                                dgvLichSu.Rows[index].Cells[4].Value = hoaDon.ThanhToan;
                            }
                        }
                    }

                    txtTongTien.Text = TinhTien().ToString();
                }
                else if (rdoXemTheoThang.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    dgvLichSu.Rows.Clear();
                    int index;
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.ToString("MM/yyyy") == dtpXemTheoNgay.Value.ToString("MM/yyyy"))
                            {
                                index = dgvLichSu.Rows.Add();
                                dgvLichSu.Rows[index].Cells[0].Value = hoaDon.MaHD;
                                dgvLichSu.Rows[index].Cells[1].Value = hoaDon.NgayLap;
                                dgvLichSu.Rows[index].Cells[2].Value = hoaDon.TongTien;
                                dgvLichSu.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                                dgvLichSu.Rows[index].Cells[4].Value = hoaDon.ThanhToan;
                            }
                        }
                    }

                    txtTongTien.Text = TinhTien().ToString();
                }
                else if (rdoXemTheoNgay.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    dgvLichSu.Rows.Clear();
                    int index;
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.ToString("dd/MM/yyyy") == dtpXemTheoNgay.Value.ToString("dd/MM/yyyy"))
                            {
                                index = dgvLichSu.Rows.Add();
                                dgvLichSu.Rows[index].Cells[0].Value = hoaDon.MaHD;
                                dgvLichSu.Rows[index].Cells[1].Value = hoaDon.NgayLap;
                                dgvLichSu.Rows[index].Cells[2].Value = hoaDon.TongTien;
                                dgvLichSu.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                                dgvLichSu.Rows[index].Cells[4].Value = hoaDon.ThanhToan;
                            }
                        }
                    }

                    txtTongTien.Text = TinhTien().ToString();
                }
                else
                {
                    dtpDenNgay.Enabled = true;
                    dgvLichSu.Rows.Clear();
                    int index;
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.Date >= dtpXemTheoNgay.Value.Date && hoaDon.NgayLap.Value.Date <= dtpDenNgay.Value.Date)
                            {
                                index = dgvLichSu.Rows.Add();
                                dgvLichSu.Rows[index].Cells[0].Value = hoaDon.MaHD;
                                dgvLichSu.Rows[index].Cells[1].Value = hoaDon.NgayLap;
                                dgvLichSu.Rows[index].Cells[2].Value = hoaDon.TongTien;
                                dgvLichSu.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                                dgvLichSu.Rows[index].Cells[4].Value = hoaDon.ThanhToan;
                            }
                        }
                    }

                    txtTongTien.Text = TinhTien().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private long TinhTien()
        {
            long tong = 0;
            for (int i = 0; i < dgvLichSu.Rows.Count; i++)
            {
                tong += long.Parse(dgvLichSu.Rows[i].Cells[2].Value.ToString());
            }
            return tong;
        }


        private void dtpXemTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }


        private void rdo_Change(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void dgvLichSu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                FrmCTBan frm = new FrmCTBan(dgvLichSu.Rows[e.RowIndex].Cells[0].Value.ToString());
                frm.Show();
            }
            
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "" || txtTimKiem.Text == "Nhập hóa đơn")
                LoadDanhSachHoaDon();
            else
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    HoaDon h = _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == txtTimKiem.Text);
                    if (h != null)
                    {
                        dgvLichSu.Rows.Clear();
                        int i = dgvLichSu.Rows.Add();
                        dgvLichSu.Rows[i].Cells[0].Value = h.MaHD;
                        dgvLichSu.Rows[i].Cells[1].Value = h.NgayLap.Value.Date;
                        dgvLichSu.Rows[i].Cells[2].Value = h.TongTien;
                        dgvLichSu.Rows[i].Cells[3].Value = h.NhanVien.TenNV;
                        dgvLichSu.Rows[i].Cells[4].Value = h.ThanhToan;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã hóa đơn");
                    }
                }
            }
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập hóa đơn")
                txtTimKiem.Text = "";
        }

        private void txtTimKiem_Validated(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                txtTimKiem.Text = "Nhập hóa đơn";
        }
    }
}
