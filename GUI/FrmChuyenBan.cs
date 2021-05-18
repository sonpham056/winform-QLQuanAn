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
    public partial class FrmChuyenBan : Form
    {
        private FrmBan frmBan;
        private FrmMenu frmMenu;
        private Button btn;

        private Color comfirmColor = Color.Yellow;
        private Color defaultColor = SystemColors.Control;
        public FrmChuyenBan()
        {
            InitializeComponent();
        }

        public FrmChuyenBan(FrmBan frmBan, FrmMenu frmMenu, Button btn)
        {
            InitializeComponent();
            this.frmBan = frmBan;
            this.frmMenu = frmMenu;
            this.btn = btn;
        }

        private void FrmChuyenBan_Load(object sender, EventArgs e)
        {
            LoadCmbBan();
        }

        private void LoadCmbBan()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < frmBan.grbBan.Controls.Count; i++)
            {
                if (frmBan.grbBan.Controls[i].BackColor != comfirmColor)
                    list.Add(frmBan.grbBan.Controls[i].Name);
            }
            list.Sort();
            cmbBan.DataSource = list;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                HoaDon hoaDon = GetHoaDon();
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == btn.Name && a.HoaDon.ThanhToan == "Chưa"))
                    {
                        _dbContext.CTBans.Remove(c);
                    }

                    for (int i = 0; i < frmMenu.dgvMenu.Rows.Count; i++)
                    {
                        CTBan ct = new CTBan();
                        ct.MaHD = hoaDon.MaHD;
                        ct.MaBan = cmbBan.Text;
                        ct.MaMA = frmMenu.dgvMenu.Rows[i].Cells[3].Value.ToString();
                        ct.SoLuong = int.Parse(frmMenu.dgvMenu.Rows[i].Cells[1].Value.ToString());

                        _dbContext.CTBans.Add(ct);
                    }

                    _dbContext.SaveChanges();
                    MessageBox.Show("Chuyển bàn thành công!");

                    frmBan.FrmBan_Load(sender, e);
                    frmMenu.dgvMenu.Rows.Clear();

                    btn.BackColor = defaultColor;
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private HoaDon GetHoaDon()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == btn.Name && a.HoaDon.ThanhToan == "Chưa"))
                {
                    //if (c.HoaDon.NgayLap.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
                    return _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == c.MaHD);
                }
            }
            return null;
        }
    }
}
