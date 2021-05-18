﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanAn.Model;
namespace QuanLyQuanAn
{
    public partial class FrmKhachHangXemDatBan : Form
    {
        private Color defaultColor = SystemColors.Control;
        private Color confirmColor = Color.Yellow;
        public FrmKhachHangXemDatBan()
        {
            InitializeComponent();
        }

        private void LoadDanhSachPhieuDatBan()
        {
            for (int i = 0; i < grbBan.Controls.Count; i++)
            {
                grbBan.Controls[i].BackColor = defaultColor;
            }
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (PhieuDatBan p in _dbContext.PhieuDatBans.ToList())
                {
                    if (dtpNgayDat.Value.ToString("dd/MM/yyyy") == p.NgayDat.Value.ToString("dd/MM/yyyy") && p.Status == 1)
                    {
                        for (int i = 0; i < grbBan.Controls.Count; i++)
                        {
                            if (p.Ban.MaBan == grbBan.Controls[i].Name)
                            {
                                grbBan.Controls[i].BackColor = confirmColor;
                            }
                        }
                    }
                }
            }
        }

        private void FrmKhachHangXemDatBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
            //TransparetBackground(grbBan);
        }

        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
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
    }
}
