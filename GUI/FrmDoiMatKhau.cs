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
    public partial class FrmDoiMatKhau : Form
    {
        private string ma;
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }

        public FrmDoiMatKhau(string ma)
        {
            InitializeComponent();
            this.ma = ma;
            TransparetBackground(label1);
            TransparetBackground(label2);
            TransparetBackground(label3);
            TransparetBackground(label4);
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMKHienTai.Text == "" || txtMKMoi.Text == "" || txtXacNhan.Text == "")
                    throw new Exception("Vui lòng nhập đủ thông tin!!");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    TaiKhoanNV taiKhoan = _dbContext.TaiKhoanNVs.FirstOrDefault(a => a.MaNV == ma);
                    if (taiKhoan != null)
                    {
                        if (taiKhoan.MK != txtMKHienTai.Text)
                            throw new Exception("Mật khẩu không đúng");
                        if (txtMKMoi.Text != txtXacNhan.Text)
                            throw new Exception("Vui lòng xác nhận đúng mật khẩu mới");
                        taiKhoan.MK = txtMKMoi.Text;
                        MessageBox.Show("Đổi mật khẩu thành công");
                        _dbContext.SaveChanges();
                    }
                    else
                    {
                        TaiKhoanKH taiKhoanKH = _dbContext.TaiKhoanKHs.FirstOrDefault(a => a.MaKH == ma);
                        if (taiKhoanKH.MK != txtMKHienTai.Text)
                            throw new Exception("Mật khẩu không đúng");
                        if (txtMKMoi.Text != txtXacNhan.Text)
                            throw new Exception("Vui lòng xác nhận đúng mật khẩu mới");
                        taiKhoanKH.MK = txtMKMoi.Text;
                        MessageBox.Show("Đổi mật khẩu thành công");
                        _dbContext.SaveChanges();
                    }
                   
                }
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
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
