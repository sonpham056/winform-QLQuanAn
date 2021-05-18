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
    public partial class FrmKhachHangXemMenu : Form
    {
        public FrmKhachHangXemMenu()
        {
            InitializeComponent();
        }

        private void FrmKhachHangXemMenu_Load(object sender, EventArgs e)
        {
            GenerateMonAn();
            GenerateMonAnTV();
            tvMonAn.Visible = false;
        }
        private void GenerateMonAn()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (MonAn monAn in _dbContext.MonAns.Where(a => a.Status == 1).ToList())
                {
                    Button btn = new Button();
                    btn.Text = monAn.TenMA + ": " + monAn.GiaTien;
                    btn.Name = monAn.MaMA;
                    btn.Size = new Size(120, 40);
                    flpMonAn.Controls.Add(btn);
                }
            }
        }

        private void GenerateMonAnTV()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                int i = 0;
                foreach (LoaiMonAn l in _dbContext.LoaiMonAns.ToList())
                {
                    tvMonAn.Nodes.Add(l.Loai);
                    foreach (MonAn monAn in _dbContext.MonAns.Where(a => a.MaLoaiMonAn == l.MaLoaiMonAn && a.Status == 1).ToList())
                        tvMonAn.Nodes[i].Nodes.Add(monAn.MaMA, monAn.TenMA + ": " + monAn.GiaTien);
                    i++;
                }
            }
        }

        private void btnBtn_Click(object sender, EventArgs e)
        {
            tvMonAn.Visible = false;
            flpMonAn.Visible = true;
        }

        private void btnTV_Click(object sender, EventArgs e)
        {
            tvMonAn.Visible = true;
            flpMonAn.Visible = false;
        }
    }
}
