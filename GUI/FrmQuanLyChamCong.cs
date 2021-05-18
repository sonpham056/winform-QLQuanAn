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
    public partial class FrmQuanLyChamCong : Form
    {
        public FrmQuanLyChamCong()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            dgvChamCong.Rows.Clear();
            try
            {
                if (txtMaNV.Text == "" || txtMaNV.Text.Length > 10)
                    throw new Exception("Dữ liệu không hợp lệ");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    if (cbXemTheoThang.Checked == true)
                    {
                        DateTime d = dtpThang.Value;
                        foreach (BangChamCong b in _dbContext.BangChamCongs.Where(a => a.TGBatDau.Value.Month == d.Month && a.MaNV == txtMaNV.Text).ToList())
                        {
                            int index = dgvChamCong.Rows.Add();
                            dgvChamCong.Rows[index].Cells[0].Value = b.STT;
                            dgvChamCong.Rows[index].Cells[1].Value = b.TGBatDau;
                            if (b.TGKetThuc != null)
                            {
                                dgvChamCong.Rows[index].Cells[2].Value = b.TGKetThuc;
                                dgvChamCong.Rows[index].Cells[3].Value = Math.Round(b.TGKetThuc.Value.Subtract(b.TGBatDau.Value).TotalHours, 2);
                            }
                            dgvChamCong.Rows[index].Cells[4].Value = b.MaNV;
                            dgvChamCong.Rows[index].Cells[5].Value = b.NhanVien.TenNV;
                        }
                    }
                    else
                    {
                        foreach (BangChamCong b in _dbContext.BangChamCongs.Where(a => a.MaNV == txtMaNV.Text).ToList())
                        {
                            int index = dgvChamCong.Rows.Add();
                            dgvChamCong.Rows[index].Cells[0].Value = b.STT;
                            dgvChamCong.Rows[index].Cells[1].Value = b.TGBatDau;
                            if (b.TGKetThuc != null)
                            {
                                dgvChamCong.Rows[index].Cells[2].Value = b.TGKetThuc;
                                dgvChamCong.Rows[index].Cells[3].Value = Math.Round(b.TGKetThuc.Value.Subtract(b.TGBatDau.Value).TotalHours, 2);
                            }
                            dgvChamCong.Rows[index].Cells[4].Value = b.MaNV;
                            dgvChamCong.Rows[index].Cells[5].Value = b.NhanVien.TenNV;
                        }
                    }
                }
                TongGioLam();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbXemTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbXemTheoThang.Checked == true)
            {
                dtpThang.Enabled = true;
            }
            else
                dtpThang.Enabled = false;
        }

        private void TongGioLam()
        {
            double d = 0;
            for (int i = 0; i < dgvChamCong.Rows.Count; i++)
            {
                if (dgvChamCong.Rows[i].Cells[3].Value == null)
                    continue;
                d += double.Parse(dgvChamCong.Rows[i].Cells[3].Value.ToString());
            }
            txtTong.Text = Math.Round(d, 2).ToString();
        }
    }
}
