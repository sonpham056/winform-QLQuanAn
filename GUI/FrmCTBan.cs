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
    public partial class FrmCTBan : Form
    {
        private string MaHD;

        public FrmCTBan()
        {
            InitializeComponent();
        }

        public FrmCTBan(string maHD)
        {
            InitializeComponent();
            MaHD = maHD;
        }

        private void FrmCTBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachCTBan();
        }

        private void LoadDanhSachCTBan()
        {
            try
            {
                int index;
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    dgvCTBan.Rows.Clear();
                    foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaHD == MaHD).ToList())
                    {
                        index = dgvCTBan.Rows.Add();
                        dgvCTBan.Rows[index].Cells[0].Value = c.MaHD;
                        dgvCTBan.Rows[index].Cells[1].Value = c.MaBan;
                        dgvCTBan.Rows[index].Cells[2].Value = c.MonAn.TenMA;
                        dgvCTBan.Rows[index].Cells[3].Value = c.SoLuong;
                        dgvCTBan.Rows[index].Cells[4].Value = c.SoLuong * c.MonAn.GiaTien;
                    }

                    long s = 0;
                    for (int i = 0; i < dgvCTBan.Rows.Count; i++)
                    {
                        s += long.Parse(dgvCTBan.Rows[i].Cells[4].Value.ToString());
                    }
                    txtTongTien.Text = s.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //private void dgvCTBan_CellClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (var _dbContext = new QuanLyQuanAnContextDB())
        //        {
        //            CTBan c = _dbContext.CTBans.FirstOrDefault(a => a.MaHD == txtMaHD.Text);
        //            if (c != null)
        //            {
        //                _dbContext.CTBans.Remove(c);
        //                _dbContext.SaveChanges();
        //            }
        //        }
        //        LoadDanhSachCTBan();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
