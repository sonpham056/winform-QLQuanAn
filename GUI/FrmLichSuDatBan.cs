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
    public partial class FrmLichSuDatBan : Form
    {
        public FrmLichSuDatBan()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhieuDatBan()
        {
            dgvLichSu.Rows.Clear();
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                if (rdoXemTatCa.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                    {
                        int index = dgvLichSu.Rows.Add();
                        dgvLichSu.Rows[index].Cells[0].Value = p.MaBan;
                        dgvLichSu.Rows[index].Cells[1].Value = p.NgayDat.Value;
                        dgvLichSu.Rows[index].Cells[2].Value = p.NhanVien.TenNV;
                    }
                }
                else if (rdoXemTheoThang.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                    {
                        if (p.NgayDat.Value.Month == dtpXemTheoNgay.Value.Month)
                        {
                            int index = dgvLichSu.Rows.Add();
                            dgvLichSu.Rows[index].Cells[0].Value = p.MaBan;
                            dgvLichSu.Rows[index].Cells[1].Value = p.NgayDat.Value;
                            dgvLichSu.Rows[index].Cells[2].Value = p.NhanVien.TenNV;
                        }
                    }
                }
                else if (rdoXemTheoNam.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                    {
                        if (p.NgayDat.Value.Year == dtpXemTheoNgay.Value.Year)
                        {
                            int index = dgvLichSu.Rows.Add();
                            dgvLichSu.Rows[index].Cells[0].Value = p.MaBan;
                            dgvLichSu.Rows[index].Cells[1].Value = p.NgayDat.Value;
                            dgvLichSu.Rows[index].Cells[2].Value = p.NhanVien.TenNV;
                        }
                    }

                }
                else if (rdoXemTheoNgay.Checked == true)
                {
                    dtpDenNgay.Enabled = false;
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                    {
                        if (p.NgayDat.Value.Date == dtpXemTheoNgay.Value.Date)
                        {
                            int index = dgvLichSu.Rows.Add();
                            dgvLichSu.Rows[index].Cells[0].Value = p.MaBan;
                            dgvLichSu.Rows[index].Cells[1].Value = p.NgayDat.Value;
                            dgvLichSu.Rows[index].Cells[2].Value = p.NhanVien.TenNV;
                        }
                    }
                }
                else
                {
                    dtpDenNgay.Enabled = true;
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                    {
                        if (p.NgayDat.Value.Date >= dtpXemTheoNgay.Value.Date && p.NgayDat.Value.Date <= dtpDenNgay.Value.Date)
                        {
                            int index = dgvLichSu.Rows.Add();
                            dgvLichSu.Rows[index].Cells[0].Value = p.MaBan;
                            dgvLichSu.Rows[index].Cells[1].Value = p.NgayDat.Value;
                            dgvLichSu.Rows[index].Cells[2].Value = p.NhanVien.TenNV;
                        }
                    }
                }
            }
        }

        private void FrmLichSuDatBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
        }

        private void rdoXemTatCa_CheckedChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
        }

        private void dtpXemTheoNgay_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
        }

        private void txtTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Nhập bàn")
                txtTimKiem.Text = "";
        }

        private void txtTimKiem_Validated(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
                txtTimKiem.Text = "Nhập bàn";
        }
    }
}
