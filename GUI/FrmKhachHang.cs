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
    public partial class FrmKhachHang : Form
    {
        private FrmMain frmMain;
        private string kh;
        public FrmKhachHang()
        {
            InitializeComponent();
        }

        public FrmKhachHang(FrmMain frmMain, string kh)
        {
            InitializeComponent();
            this.frmMain = frmMain;
            this.kh = kh;
        }

        private void FrmKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void btnXemBan_Click(object sender, EventArgs e)
        {
            FormClose();
            FrmKhachHangXemBan frm = new FrmKhachHangXemBan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemMenu_Click(object sender, EventArgs e)
        {
            FormClose();
            FrmKhachHangXemMenu frm = new FrmKhachHangXemMenu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void FormClose()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Dispose();
                f.Close();
            }
        }

        private void btnXemDatBan_Click(object sender, EventArgs e)
        {
            FormClose();
            FrmKhachHangXemDatBan frm = new FrmKhachHangXemDatBan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClose();
            FrmDoiMatKhau frm = new FrmDoiMatKhau(kh);
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("width:" + panel1.Width.ToString() + " height: " + panel1.Height.ToString());
        }
    }
}
