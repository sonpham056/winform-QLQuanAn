using Microsoft.Reporting.WinForms;
using QuanLyQuanAn.Model;
using QuanLyQuanAn.Report;
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
    public partial class FrmReportHoaDon : Form
    {
        private HoaDon hd;
        private Button btn;
        public FrmReportHoaDon()
        {
            InitializeComponent();
        }

        public FrmReportHoaDon(HoaDon hd, Button btn)
        {
            InitializeComponent();
            this.hd = hd;
            this.btn = btn;
        }

        private void FrmReportHoaDon_Load(object sender, EventArgs e)
        {
            LoadReportData();
            this.rptReport.RefreshReport();
        }

        private void LoadReportData()
        {
            try
            {
                List<HoaDonReport> list = new List<HoaDonReport>();
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    foreach (CTBan c in _dbContext.CTBans.Where(a => a.MaHD == hd.MaHD).ToList())
                    {
                        HoaDonReport temp = new HoaDonReport();
                        temp.MonAn = c.MonAn.TenMA;
                        temp.SL = (long)c.SoLuong;
                        temp.Gia = (long)c.MonAn.GiaTien;

                        list.Add(temp);
                    }
                }

                rptReport.LocalReport.ReportPath = "HoaDonReport.rdlc";

                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("Ngay", hd.NgayLap.Value.ToString("dd/MM/yyyy"));
                param[1] = new ReportParameter("Ban", btn.Name);
                rptReport.LocalReport.SetParameters(param);
                var ds = new ReportDataSource("HoaDonDataSet", list);
                rptReport.LocalReport.DataSources.Clear();
                rptReport.LocalReport.DataSources.Add(ds);
                rptReport.ZoomMode = ZoomMode.PageWidth;
                rptReport.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
