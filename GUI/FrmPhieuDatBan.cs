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
    public partial class FrmPhieuDatBan : Form
    {
        private FrmDatBan frmDatBan;
        private PhieuDatBan pdb;
        private Button btn;
        private string sdt;

        private Color confirmColor = Color.Yellow;

        public FrmPhieuDatBan()
        {
            InitializeComponent();
        }

        public FrmPhieuDatBan(FrmDatBan frmDatBan, PhieuDatBan pdb, Button btn, string sdt)
        {
            InitializeComponent();
            this.pdb = pdb;
            this.btn = btn;
            this.sdt = sdt;
            this.frmDatBan = frmDatBan;
        }

        private void FrmPhieuDatBan_Load(object sender, EventArgs e)
        {
            if (btn.BackColor != confirmColor)
            {
                txtBan.Text = pdb.MaBan;
                txtKhachHang.Text = pdb.MaKH;
                txtMaNV.Text = pdb.MaNV;
                txtNgayDatCoc.Text = pdb.NgayDat.ToString();
                txtSDT.Text = sdt;
                cmbTrangThai.Text = pdb.TrangThaiDatCoc;

                if (btn.BackColor != confirmColor)
                    btnHuy.Enabled = false;
            }
            else
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.Where(a => a.MaBan == btn.Name).ToList())
                    {
                        if (p.NgayDat.Value.Date == frmDatBan.dtpNgayDat.Value.Date)
                        {
                            txtBan.Text = p.MaBan;
                            txtKhachHang.Text = p.MaKH;
                            txtMaNV.Text = p.MaNV;
                            txtNgayDatCoc.Text = p.NgayDat.ToString();
                            txtSDT.Text = p.KhachHang.SDT;
                            cmbTrangThai.Text = p.TrangThaiDatCoc;
                        }
                    }
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đặt bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    pdb.TrangThaiDatCoc = cmbTrangThai.Text;
                    _dbContext.PhieuDatBans.Add(pdb);
                    _dbContext.SaveChanges();
                }
                btn.BackColor = confirmColor;
                this.Close();
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy đơn đặt bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (PhieuDatBan p in _dbContext.PhieuDatBans.Where(a => a.MaBan == btn.Name).ToList())
                    {
                        if (p.NgayDat.Value.Date == frmDatBan.dtpNgayDat.Value.Date)
                        {
                            p.Status = 0;
                            _dbContext.SaveChanges();
                        }
                    }
                }
                btn.BackColor = SystemColors.Control;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (PhieuDatBan p in _dbContext.PhieuDatBans.Where(a => a.MaBan == btn.Name).ToList())
                {
                    if (p.NgayDat.Value.Date == frmDatBan.dtpNgayDat.Value.Date)
                    {
                        p.TrangThaiDatCoc = cmbTrangThai.Text;
                        _dbContext.SaveChanges();
                        MessageBox.Show("Đã lưu thay đổi", "Thông báo");
                    }
                }
            }
        }
    }
}
