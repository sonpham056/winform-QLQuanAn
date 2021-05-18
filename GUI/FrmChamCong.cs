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
    public partial class FrmChamCong : Form
    {
        public FrmChamCong()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using(var _dbContext = new QuanLyQuanAnContextDB())
            {
                dgvChamCong.Rows.Clear();
                foreach (BangChamCong bcc in _dbContext.BangChamCongs.ToList())
                {
                    int index = dgvChamCong.Rows.Add();
                    dgvChamCong.Rows[index].Cells[0].Value = bcc.STT;
                    dgvChamCong.Rows[index].Cells[1].Value = bcc.TGBatDau;
                    dgvChamCong.Rows[index].Cells[2].Value = bcc.TGKetThuc;
                    dgvChamCong.Rows[index].Cells[3].Value = bcc.MaNV;
                    dgvChamCong.Rows[index].Cells[4].Value = bcc.NhanVien.TenNV;
                }
            }
        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTK.Text == "")
                    throw new Exception("Nhap ma nhan vien");
                if (MessageBox.Show("Bắt đầu ca làm việc?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    BangChamCong bcc = new BangChamCong();
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        NhanVien nv = _dbContext.NhanViens.FirstOrDefault(a => a.MaNV == txtTK.Text);
                        if (nv == null)
                            throw new Exception("Không tồn tại nhân viên " + txtTK.Text);
                        BangChamCong temp = _dbContext.BangChamCongs.OrderByDescending(a => a.STT).FirstOrDefault(a => a.MaNV == nv.MaNV);
                        if (temp.TGKetThuc != null)
                        {
                            bcc.TGBatDau = DateTime.Now;
                            bcc.MaNV = txtTK.Text;
                            _dbContext.BangChamCongs.Add(bcc);
                            _dbContext.SaveChanges();
                        }
                        else
                            throw new Exception("Nhân viên có mã: " + nv.MaNV + " chưa kết thúc ca làm!");
                    }
                    LoadData();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                txtSTT.Text = dgvChamCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTK.Text = dgvChamCong.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            try
            {
                BangChamCong bcc = new BangChamCong();
                if (txtSTT.Text == "")
                    throw new Exception("Vui lòng chọn một nhân viên để kết thúc");
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    int temp = int.Parse(txtSTT.Text);
                    bcc = _dbContext.BangChamCongs.FirstOrDefault(b => b.STT == temp);
                    if (bcc.TGKetThuc != null)
                        throw new Exception("Nhân viên này đã chấm công rồi");
                    bcc.TGKetThuc = DateTime.Now;
                    _dbContext.SaveChanges();
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
