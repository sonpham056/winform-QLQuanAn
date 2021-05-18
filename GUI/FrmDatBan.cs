using QuanLyQuanAn.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanAn.GUI
{
    public partial class FrmDatBan : Form
    {
        private NhanVien nv;
        private Color defaultColor = SystemColors.Control;
        private Color confirmColor = Color.Yellow;
        public FrmDatBan()
        {
            InitializeComponent();
        }

        public FrmDatBan(NhanVien nv)
        {
            InitializeComponent();
            this.nv = nv;
        }

        private void FrmDatBan_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
            txtNhanVien.Text = nv.MaNV;
            LoadCmbKhachHang();
        }

        private void LoadCmbKhachHang()
        {
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                cmbKhachHang.DataSource = _dbContext.KhachHangs.ToList(); //sự kiện selected index changed sẽ kích hoạt
                cmbKhachHang.DisplayMember = "TenKH";
                cmbKhachHang.ValueMember = "MaKH";
                txtSDT.Text = _dbContext.KhachHangs.FirstOrDefault(a => a.MaKH == cmbKhachHang.SelectedValue.ToString()).SDT;
                cmbTrangThaiDatCoc.SelectedIndex = 0;
            }
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

        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {
            LoadDanhSachPhieuDatBan();
        }

        private void DatBan_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn = (Button)sender;
                if (btn.BackColor != confirmColor)
                    if (dtpNgayDat.Value.Date.CompareTo(DateTime.Now.Date) < 0)
                        throw new Exception("Ngày đặt phải bằng hoặc lớn hơn ngày hiện tại!!!");
                if (txtSDT.Text == "")
                    MessageBox.Show("Bạn chưa nhập số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                PhieuDatBan pdb = new PhieuDatBan();

                //pdb.KhachHang = kh;
                pdb.MaNV = txtNhanVien.Text;
                pdb.MaKH = cmbKhachHang.SelectedValue.ToString();
                pdb.MaBan = btn.Name;
                pdb.NgayDat = dtpNgayDat.Value;
                pdb.TrangThaiDatCoc = cmbTrangThaiDatCoc.Text;
                pdb.Status = 1;

                FrmPhieuDatBan frm = new FrmPhieuDatBan(this, pdb, btn, txtSDT.Text);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhachHang.DisplayMember = "TenKH";//khi sự kiện kích hoạt, thì hiển thị lên combobox dữ liệu
            cmbKhachHang.ValueMember = "MaKH";
            using (var _dbContext = new QuanLyQuanAnContextDB())
            {
                txtSDT.Text = _dbContext.KhachHangs.FirstOrDefault(a => a.MaKH == cmbKhachHang.SelectedValue.ToString()).SDT;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dtpNgayDat.Value =  dtpNgayDat.Value.AddSeconds(1);
        }
    }
}
