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
    public partial class FrmMenu : Form
    {
        private FrmBan frmBan; //kết nối đến form bàn
        private Button btn; //lấy được button kích hoạt sự kiện
        private string name; //lấy tên nhân viên 


        private Color confirmColor = Color.Yellow;
        private Color defaultColor = SystemColors.Control;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(FrmBan frmBan, Button btn, string name)
        {
            InitializeComponent();
            this.frmBan = frmBan;
            this.btn = btn;
            this.name = name;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            GenerateMonAn();
            GenerateMonAnTV();
            LoadDanhSachCTBan();
            flpMonAn.Visible = false;
        }

        private void LoadDanhSachCTBan()
        {
            int index;
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == btn.Name && a.HoaDon.ThanhToan == "Chưa"))
                {
                    index = dgvMenu.Rows.Add();
                    dgvMenu.Rows[index].Cells[0].Value = c.MonAn.TenMA;
                    dgvMenu.Rows[index].Cells[1].Value = c.SoLuong;
                    dgvMenu.Rows[index].Cells[2].Value = c.MonAn.GiaTien * c.SoLuong;
                    dgvMenu.Rows[index].Cells[3].Value = c.MaMA;
                }
            }
        }

        #region button flpMonAn
        private void GenerateMonAn()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                foreach (MonAn monAn in _dbContext.MonAns.Where(a => a.Status == 1))
                {
                    Button btn = new Button();
                    btn.Text = monAn.TenMA + ": " + monAn.GiaTien;
                    btn.Name = monAn.MaMA;
                    btn.Size = new Size(115, 40);
                    btn.Click += new EventHandler(AddMonAn);
                    flpMonAn.Controls.Add(btn);
                }
            }
        }

        private void AddMonAn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int index = GetIndex(btn.Name);
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                MonAn monAn = _dbContext.MonAns.FirstOrDefault(a => a.MaMA == btn.Name);
                if (index != -1)
                {
                    dgvMenu.Rows[index].Cells[1].Value = int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString()) + 1;
                    //int temp = int.Parse(dgvMenu.Rows[index].Cells[2].Value.ToString());
                    dgvMenu.Rows[index].Cells[2].Value = monAn.GiaTien * int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString());
                }
                else
                {
                    index = dgvMenu.Rows.Add();
                    dgvMenu.Rows[index].Cells[0].Value = monAn.TenMA;
                    dgvMenu.Rows[index].Cells[2].Value = monAn.GiaTien;
                    dgvMenu.Rows[index].Cells[3].Value = monAn.MaMA;
                    dgvMenu.Rows[index].Cells[1].Value = 1;
                }
                txtMaMA.Text = monAn.MaMA;
                txtMonAn.Text = monAn.TenMA;
                txtSoLuong.Text = dgvMenu.Rows[index].Cells[1].Value.ToString();
            }
            TongTien();
        }

        #endregion

        #region treeview
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

        private void tvMonAn_AfterSelect(object sender, TreeViewEventArgs e)
        {
            AddMonAn();
        }

        private void AddMonAn()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                if (tvMonAn.SelectedNode != null)
                {
                    int index = GetIndex(tvMonAn.SelectedNode.Name);
                    MonAn monAn = _dbContext.MonAns.FirstOrDefault(a => a.MaMA == tvMonAn.SelectedNode.Name);
                    if (monAn != null)
                    {
                        if (index == -1)
                        {
                            index = dgvMenu.Rows.Add();
                            dgvMenu.Rows[index].Cells[0].Value = monAn.TenMA;
                            dgvMenu.Rows[index].Cells[2].Value = monAn.GiaTien;
                            dgvMenu.Rows[index].Cells[3].Value = monAn.MaMA;
                            dgvMenu.Rows[index].Cells[1].Value = 1;
                        }
                        txtMaMA.Text = monAn.MaMA;
                        txtMonAn.Text = monAn.TenMA;
                        txtSoLuong.Text = dgvMenu.Rows[index].Cells[1].Value.ToString();
                    }
                    TongTien();
                }
            }
        }
        #endregion

        private int GetIndex(string MaMA)
        {
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                if (dgvMenu.Rows[i].Cells[3].Value.ToString() == MaMA)
                    return i;
            }
            return -1;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhTienCong();
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtMonAn.Text = dgvMenu.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSoLuong.Text = dgvMenu.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaMA.Text = dgvMenu.Rows[e.RowIndex].Cells[3].Value.ToString();
            }

        }

        private void TinhTienCong()
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 món ăn bên bảng!");
            }
            else
            {
                int index = GetIndex(txtMaMA.Text);
                int giaTien = int.Parse(dgvMenu.Rows[index].Cells[2].Value.ToString()) / int.Parse(txtSoLuong.Text);
                dgvMenu.Rows[index].Cells[1].Value = int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString()) + 1;
                txtSoLuong.Text = (int.Parse(txtSoLuong.Text) + 1).ToString();
                dgvMenu.Rows[index].Cells[2].Value = int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString()) * giaTien;
            }
            TongTien();
        }

        private void TinhTienTru()
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 món ăn bên bảng!");
            }
            else
            {
                int index = GetIndex(txtMaMA.Text);
                if (int.Parse(txtSoLuong.Text) == 1)
                {
                    dgvMenu.Rows.RemoveAt(index);
                    txtMaMA.Text = "";
                    txtMonAn.Text = "";
                    txtSoLuong.Text = "";
                }
                else
                {
                    int giaTien = int.Parse(dgvMenu.Rows[index].Cells[2].Value.ToString()) / int.Parse(txtSoLuong.Text);
                    dgvMenu.Rows[index].Cells[1].Value = int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString()) - 1;
                    txtSoLuong.Text = (int.Parse(txtSoLuong.Text) - 1).ToString();
                    dgvMenu.Rows[index].Cells[2].Value = int.Parse(dgvMenu.Rows[index].Cells[1].Value.ToString()) * giaTien;
                }
            }
            TongTien();
        }
        private void btnTru_Click(object sender, EventArgs e)
        {
            TinhTienTru();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMonAn.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 món ăn bên bảng để xóa!");
            }
            else
            {
                int index = GetIndex(txtMaMA.Text);
                if (MessageBox.Show("Xóa món ăn: " + txtMonAn.Text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvMenu.Rows.RemoveAt(index);
                    txtMaMA.Text = "";
                    txtMonAn.Text = "";
                    txtSoLuong.Text = "";
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.Rows.Count == 0)
                    throw new Exception("Chưa chọn món ăn");
                btn.BackColor = confirmColor;
                FrmHoaDon frm = new FrmHoaDon(name);

                HoaDon h = GetHoaDon();
                if (h == null)
                {
                    //Load form kia lên để nó làm rồi tắt
                    frm.Visible = false;
                    frm.Show();
                    frm.btnThemHoaDon_Click(sender, e);
                    // những dòng code trên => Đã thêm 1 hóa đơn

                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        //Xóa tất cả ct liên quan đến mã và bàn
                        foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == this.btn.Name && a.MaHD == frm.cmbMaHD.Text).ToList())
                        {
                            _dbContext.CTBans.Remove(c);
                        }


                        h = _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == frm.cmbMaHD.Text);
                        h.ThanhToan = "Chưa";
                        //thêm lại tất cả các chi tiết món ăn
                        for (int i = 0; i < dgvMenu.Rows.Count; i++)
                        {

                            CTBan ct = new CTBan();
                            ct.MaHD = h.MaHD;
                            ct.MaBan = this.btn.Name;
                            ct.MaMA = dgvMenu.Rows[i].Cells[3].Value.ToString();
                            ct.SoLuong = int.Parse(dgvMenu.Rows[i].Cells[1].Value.ToString());

                            _dbContext.CTBans.Add(ct);
                        }
                        _dbContext.SaveChanges();
                    }
                    frm.Close();
                }
                else
                {
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        //Xóa tất cả ct liên quan đến mã và bàn
                        foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == this.btn.Name && a.MaHD == h.MaHD).ToList())
                        {
                            _dbContext.CTBans.Remove(c);
                        }

                        h.ThanhToan = "Chưa";
                        //thêm lại tất cả các chi tiết món ăn
                        for (int i = 0; i < dgvMenu.Rows.Count; i++)
                        {
                            CTBan ct = new CTBan();
                            ct.MaHD = h.MaHD;
                            ct.MaBan = this.btn.Name;
                            ct.MaMA = dgvMenu.Rows[i].Cells[3].Value.ToString();
                            ct.SoLuong = int.Parse(dgvMenu.Rows[i].Cells[1].Value.ToString());

                            _dbContext.CTBans.Add(ct);
                        }
                        _dbContext.SaveChanges();
                    }
                }
                MessageBox.Show("Lưu thành công", "Thành công");
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
                foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaBan == this.btn.Name && a.HoaDon.ThanhToan == "Chưa"))
                {
                    //if (c.HoaDon.NgayLap.Value.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
                    return _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == c.MaHD);
                }
            }
            return null;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Thanh toán bàn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (dgvMenu.Rows.Count == 0)
                        throw new Exception("Chưa chọn món ăn");
                    HoaDon h = GetHoaDon();
                    if (h == null)
                        throw new Exception("Vui lòng lưu trước khi thanh toán");
                    using (var _dbContext = new QuanLyQuanAnContextDB())
                    {
                        HoaDon hoaDon = _dbContext.HoaDons.FirstOrDefault(a => a.MaHD == h.MaHD);
                        hoaDon.ThanhToan = "Rồi";
                        int tong = 0;
                        for (int i = 0; i < dgvMenu.Rows.Count; i++)
                        {
                            tong += int.Parse(dgvMenu.Rows[i].Cells[2].Value.ToString());
                        }

                        hoaDon.TongTien = tong;
                        FrmReportHoaDon frm = new FrmReportHoaDon(hoaDon, btn);
                        frm.ShowDialog();
                        btn.BackColor = defaultColor;
                        _dbContext.SaveChanges();

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn.BackColor != confirmColor)
                    throw new Exception("Bàn này chưa gọi món");
                FrmChuyenBan frm = new FrmChuyenBan(frmBan, this, btn);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void TongTien()
        {
            long s = 0;
            for (int i = 0; i < dgvMenu.Rows.Count; i++)
            {
                s += long.Parse(dgvMenu.Rows[i].Cells[2].Value.ToString());
            }
            txtTongTien.Text = s.ToString();
        }
    }
}
