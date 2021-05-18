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
    public partial class FrmMain : Form
    {
        private FrmAdmin frmAdmin;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(FrmAdmin frmAdmin)
        {
            InitializeComponent();
            this.frmAdmin = frmAdmin;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TransparetBackground(label1);
            TransparetBackground(label2);
            TransparetBackground(btnDangNhap);
            TransparetBackground(btnHuy);
            TransparetBackground(btnThoat);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    List<TaiKhoanKH> listKH = _dbContext.TaiKhoanKHs.ToList();
                    List<TaiKhoanNV> listNV = _dbContext.TaiKhoanNVs.ToList();
                    TaiKhoanKH kh = listKH.FirstOrDefault(a => a.MaKH == txtTK.Text);
                    TaiKhoanNV nv = listNV.FirstOrDefault(a => a.MaNV == txtTK.Text);

                    if (kh != null)
                    {
                        if (kh.MK == txtMK.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công, chào " + kh.KhachHang.TenKH);
                            FrmKhachHang frm = new FrmKhachHang(this, kh.MaKH);
                            frm.Text = kh.KhachHang.TenKH;
                            frm.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu!!!");
                        }
                    }
                    else if (nv != null)
                    {
                        if (nv.MaNV == "admin" && nv.MK == txtMK.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công, chào " + nv.NhanVien.TenNV);
                            FrmAdmin frm = new FrmAdmin(this);
                            frm.Show();
                            this.Visible = false;
                        }
                        else if (nv.MK == txtMK.Text)
                        {
                            MessageBox.Show("Đăng nhập thành công, chào " + nv.NhanVien.TenNV);
                            FrmNhanVien frm = new FrmNhanVien(this, nv.NhanVien);
                            frm.Text = nv.NhanVien.TenNV;
                            frm.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu!!!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai tên tài khoản!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMK.Text = "";
            txtTK.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtTK_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "Tên đăng nhập")
                txtTK.Text = "";
        }

        private void txtTK_Validated(object sender, EventArgs e)
        {
            if (txtTK.Text == "")
                txtTK.Text = "Tên đăng nhập";
        }

        private void txtMK_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "Mật khẩu")
                txtMK.Text = "";
            txtMK.UseSystemPasswordChar = true;
        }

        private void txtMK_Validated(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Mật khẩu";
                txtMK.UseSystemPasswordChar = false;
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.UseSystemPasswordChar == false)
                txtMK.UseSystemPasswordChar = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
