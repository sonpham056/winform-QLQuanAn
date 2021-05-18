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
    public partial class FrmNhanVien : Form
    {
        FrmMain frmMain;
        NhanVien nv;
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public FrmNhanVien(FrmMain frm, NhanVien n)
        {
            InitializeComponent();
            frmMain = frm;
            nv = n;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmHoaDon frm = new FrmHoaDon(nv.MaNV);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void FrmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmBan frm = new FrmBan(nv.MaNV);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void CloseForm()
        {
            foreach(Form f in this.MdiChildren)
                f.Close();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmChamCong frm = new FrmChamCong();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void lịchSửHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmLichSu frm = new FrmLichSu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmDoiMatKhau frm = new FrmDoiMatKhau(nv.MaNV);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmQuanLyKhachHang frm = new FrmQuanLyKhachHang();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmDatBan frm = new FrmDatBan(nv);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportTongKetHoaDon frm = new FrmReportTongKetHoaDon();
            frm.ShowDialog();
        }

        private void lịchSửPhiếuĐặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
            FrmLichSuDatBan frm = new FrmLichSuDatBan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
    }
}
