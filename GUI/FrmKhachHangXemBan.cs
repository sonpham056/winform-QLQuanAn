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
    public partial class FrmKhachHangXemBan : Form
    {
        private Color defaultColor = SystemColors.Control;
        private Color confirmColor = Color.Yellow;
        public FrmKhachHangXemBan()
        {
            InitializeComponent();
        }

        private void FrmKhachHangXemBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachBan();
        }

        private void LoadDanhSachBan()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                //MessageBox.Show(frm.dtpDate.Value.ToString("dd/MM/yyyy"));
                foreach (CTBan c in _dbContext.CTBans.Where(a => a.HoaDon.ThanhToan == "Chưa").ToList())
                {
                    //if (c.HoaDon.NgayLap.Value.ToString("dd/MM/yyyy") == frm.dtpDate.Value.ToString("dd/MM/yyyy"))
                    for (int i = 0; i < grbBan.Controls.Count; i++)
                    {
                        if (c.Ban.MaBan == grbBan.Controls[i].Name)
                        {
                            grbBan.Controls[i].BackColor = confirmColor;
                        }
                    }
                }
            }
        }
    }
}
