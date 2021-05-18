using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Model;

namespace QuanLyQuanAn.GUI
{
    public partial class FrmAdmin : Form
    {
        FrmMain frmMain;
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public FrmAdmin(FrmMain frm)
        {
            InitializeComponent();
            frmMain = frm;
        }


        #region event
        private void chỉnhSửaNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormChinhSuaNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMain.Visible = true;
        }

        private void btnChinhSuaNV_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormChinhSuaNhanVien();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnChinhSuaMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormChinhSuaMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void chỉnhSửaMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormChinhSuaMonAn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lichSuHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormLichSuHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormQuanLyKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mậtKhẩuNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormQuanLyMatKhau();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormDoiMatKhau();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDatBan_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormDatBan();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void lịchSửĐặtBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormLichSuDatBan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ShowFormQuanLyChamCong();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region method
        private void ShowFormChinhSuaNhanVien()
        {
            CloseForm();
            FrmChinhSuaNV frm = new FrmChinhSuaNV();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }



        private void ShowFormChinhSuaMonAn()
        {
            CloseForm();
            FrmChinhSuaMonAn frm = new FrmChinhSuaMonAn();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ShowFormBan()
        {
            CloseForm();
            FrmBan frm = new FrmBan("admin");
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void CloseForm()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Dispose();
                f.Close();
            }
        }
        private void ShowFormHoaDon()
        {
            CloseForm();
            FrmHoaDon frm = new FrmHoaDon("admin");
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ShowFormLichSuHoaDon()
        {
            CloseForm();
            FrmLichSu frm = new FrmLichSu();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ShowFormQuanLyKhachHang()
        {
            CloseForm();
            FrmQuanLyKhachHang frm = new FrmQuanLyKhachHang();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ShowFormQuanLyMatKhau()
        {
            CloseForm();
            FrmQuanLyMatKhau frm = new FrmQuanLyMatKhau();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        private void ShowFormDoiMatKhau()
        {
            CloseForm();
            FrmDoiMatKhau frm = new FrmDoiMatKhau("admin");
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void ShowFormDatBan()
        {
            CloseForm();
            FrmDatBan frm = new FrmDatBan(GetAdmin());
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private NhanVien GetAdmin()
        {
            NhanVien nv;
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                nv = _dbContext.NhanViens.FirstOrDefault(a => a.MaNV == "admin");
            }
            return nv;
        }

        private void ShowFormLichSuDatBan()
        {
            CloseForm();
            FrmLichSuDatBan frm = new FrmLichSuDatBan();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }


        private void ShowFormQuanLyChamCong()
        {
            CloseForm();
            FrmQuanLyChamCong frm = new FrmQuanLyChamCong();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        #endregion

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportTongKetHoaDon frm = new FrmReportTongKetHoaDon();
            frm.ShowDialog();
        }


    }
}
