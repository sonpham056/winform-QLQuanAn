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
    public partial class FrmBan : Form
    {
        private string name;
        private Color confirmColor = Color.Yellow;
        private Color defaultColor = SystemColors.Control;
        public FrmBan()
        {
            InitializeComponent();
        }

        public FrmBan(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        private void Ban_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            FrmMenu frm = new FrmMenu(this, btn, name);
            frm.Show();
        }

        public void FrmBan_Load(object sender, EventArgs e)
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
