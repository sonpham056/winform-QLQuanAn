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
    public partial class FrmHoaDon : Form
    {
        string name;
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        public FrmHoaDon(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        public void FrmHoaDon_Load(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
            LoadCmbMaHD();
            DTPUpdate();
            LoadCmbBan();
            txtNhanVien.Text = name;
            if (name != "admin")
            {
                //btnSua.Enabled = false;
                //btnChiTietHD.Enabled = false;
            }
        }
        
        private void LoadDanhSachHoaDon()
        {
            try
            {
                dgvHoaDon.Rows.Clear();
                int index;
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                    {
                        if (hoaDon.NgayLap.Value.ToString("dd/MM/yyyy") == dtpDate.Value.ToString("dd/MM/yyyy"))
                        {
                            index = dgvHoaDon.Rows.Add();
                            dgvHoaDon.Rows[index].Cells[0].Value = hoaDon.MaHD;
                            dgvHoaDon.Rows[index].Cells[1].Value = hoaDon.NgayLap.Value.ToString("dd/MM/yyyy hh:mm:ss");
                            dgvHoaDon.Rows[index].Cells[2].Value = hoaDon.TongTien;
                            dgvHoaDon.Rows[index].Cells[3].Value = hoaDon.NhanVien.TenNV;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachHoaDon();
            txtTongTienNgay.Text = TinhTien().ToString();
        }

        private void LoadCmbMaHD()
        {
            try
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    List<HoaDon> reserve = new List<HoaDon>();
                    for (int i = _dbContext.HoaDons.ToList().Count - 1; i >= 0; i--)
                    {
                        reserve.Add(_dbContext.HoaDons.ToList()[i]);
                    }
                    if (reserve.Count > 0)
                    {
                        cmbMaHD.DataSource = reserve;
                        cmbMaHD.DisplayMember = "MaHD";
                        cmbMaHD.ValueMember = "MaHD";
                        cmbMaHD.SelectedIndex = 0;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtTongTien.Text, out _) && txtTongTien.Text != "")
            {
                errorProvider1.SetError(txtTongTien, "Vui lòng nhập số");
            }
            else
                errorProvider1.Clear();
        }

        public void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    HoaDon hoaDon = new HoaDon();
                    DTPUpdate();
                    if (cmbMaHD.Items.Count == 0)
                    {
                        hoaDon.MaHD = "HD001";
                        hoaDon.NgayLap = dtpDate.Value;
                        hoaDon.MaNV = txtNhanVien.Text;
                        hoaDon.TongTien = 0;
                        hoaDon.ThanhToan = "Chưa";
                    }
                    else
                    {
                        NhanVien nhanVien = _dbContext.NhanViens.FirstOrDefault(a => a.MaNV == txtNhanVien.Text);
                        cmbMaHD.SelectedIndex = 0;
                        hoaDon.MaHD = LayMaHD(cmbMaHD.Text);
                        hoaDon.NgayLap = dtpDate.Value;
                        hoaDon.NhanVien = nhanVien;
                        hoaDon.TongTien = 0;
                        hoaDon.ThanhToan = "Chưa";
                    }

                    _dbContext.HoaDons.Add(hoaDon);
                    _dbContext.SaveChanges();
                }

                LoadDanhSachHoaDon();
                LoadCmbMaHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string LayMaHD(string str)
        {
            int num = 0;
            if (str.Length == 4)
            {
                num = (str[2] - 48) * 10 + (str[3] - 48) + 1;
            }
            else
            {

                num = (str[2] - 48) * 100 + (str[3] - 48) * 10 + (str[4] - 48) + 1;
            }
            if (num < 10)
            {
                return "HD00" + num;
            }
            else if (num < 100)
            {
                return "HD0" + num;
            }
            return "HD" + num.ToString();
        }

        private void DTPUpdate()
        {
            dtpDate.Value = DateTime.Now;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtTongTien.Text = dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbMaHD.SelectedIndex = cmbMaHD.FindStringExact(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    HoaDon hoaDon = _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == cmbMaHD.Text);
                    if (hoaDon != null)
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa hóa đơn " + hoaDon.MaHD + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            _dbContext.HoaDons.Remove(hoaDon);
                            _dbContext.SaveChanges();
                        }
                    }
                }

                LoadDanhSachHoaDon();
                LoadCmbMaHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadCmbBan()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                cmbBan.DataSource = _dbContext.Bans.ToList();
                cmbBan.DisplayMember = "MaBanTrangThai";
                cmbBan.ValueMember = "MaBan";
            }
        }

        private void btnChiTietHD_Click(object sender, EventArgs e)
        {
            FrmCTBan frm = new FrmCTBan(cmbMaHD.Text);
            frm.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    if (cmbMaHD.Text == "" || txtTongTien.Text == "")
                        throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    HoaDon hoaDon = _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == cmbMaHD.Text);

                    hoaDon.TongTien = int.Parse(txtTongTien.Text);

                    _dbContext.SaveChanges();
                }

                LoadDanhSachHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private long TinhTien()
        {
            long tong = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count; i++)
            {
                tong += long.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
            }
            return tong;
        }
        //private void LoadCmbNhanVien()
        //{
        //    try
        //    {
        //        using (var _dbContext = new QuanLyQuanAnContextDB())
        //        {
        //            cmbNhanVien.DataSource = _dbContext.NhanViens.ToList();
        //            cmbNhanVien.DisplayMember = "TenNV";
        //            cmbNhanVien.ValueMember = "MaNV";
        //            cmbNhanVien.SelectedIndex = 0;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
