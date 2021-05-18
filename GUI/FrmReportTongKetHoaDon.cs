using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyQuanAn.Model;
using QuanLyQuanAn.Report;

namespace QuanLyQuanAn.GUI
{
    public partial class FrmReportTongKetHoaDon : Form
    {
        ReportParameter[] param = new ReportParameter[2];

        public FrmReportTongKetHoaDon()
        {
            InitializeComponent();
        }

        private void FrmReportTongKetHoaDon_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            XuatHoaDon();
            rptViewer.Visible = true;
        }

        private void XuatHoaDon()
        {
            try
            {
                List<TongKetHoaDonReport> list = new List<TongKetHoaDonReport>();
                using (var _dbContext = new QuanLyQuanAnContextDB())
                {
                    if (rdXemTheoNgay.Checked == true)
                    {
                        param[0] = new ReportParameter("Ngay", dtpXemTheoNgay.Value.ToString("dd/MM/yyyy"));
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.Date == dtpXemTheoNgay.Value.Date)
                            {
                                TongKetHoaDonReport temp = new TongKetHoaDonReport();
                                temp.MaHD = hoaDon.MaHD;
                                temp.NgayLap = hoaDon.NgayLap.Value;
                                temp.TongTien = (long)hoaDon.TongTien;

                                list.Add(temp);
                            }
                        }
                    }
                    else if (rdXemTheoThang.Checked == true)
                    {
                        param[0] = new ReportParameter("Ngay", dtpXemTheoThang.Value.ToString("dd/MM/yyyy"));
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.Month == dtpXemTheoThang.Value.Month)
                            {
                                TongKetHoaDonReport temp = new TongKetHoaDonReport();
                                temp.MaHD = hoaDon.MaHD;
                                temp.NgayLap = hoaDon.NgayLap.Value;
                                temp.TongTien = (long)hoaDon.TongTien;
                                list.Add(temp);
                            }
                        }
                    }
                    else
                    {
                        param[0] = new ReportParameter("Ngay", dtpTuNgay.Value.ToString("dd/MM/yyyy") + " Đến " + dtpDenNgay.Value.ToString("dd/MM/yyyy"));
                        foreach (HoaDon hoaDon in _dbContext.HoaDons.ToList())
                        {
                            if (hoaDon.NgayLap.Value.Date >= dtpTuNgay.Value.Date && hoaDon.NgayLap.Value.Date <= dtpDenNgay.Value.Date)
                            {
                                TongKetHoaDonReport temp = new TongKetHoaDonReport();
                                temp.MaHD = hoaDon.MaHD;
                                temp.NgayLap = hoaDon.NgayLap.Value;
                                temp.TongTien = (long)hoaDon.TongTien;
                                list.Add(temp);
                            }
                        }
                    }

                    rptViewer.LocalReport.ReportPath = "TongKetHoaDonReport.rdlc";
                    param[1] = new ReportParameter("NgayThangNam", "Ngày " + DateTime.Now.Day.ToString() + " Tháng " + DateTime.Now.Month.ToString() + " Năm " + DateTime.Now.Year.ToString());
                    rptViewer.LocalReport.SetParameters(param);
                    var ds = new ReportDataSource("TongKetHoaDonDataSet", list);
                    rptViewer.LocalReport.DataSources.Clear();
                    rptViewer.LocalReport.DataSources.Add(ds);

                    rptViewer.ZoomMode = ZoomMode.PageWidth;

                    rptViewer.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Check_changed(object sender, EventArgs e)
        {
            if (rdXemTheoNgay.Checked == true)
            {
                dtpXemTheoNgay.Enabled = true;
                dtpXemTheoThang.Enabled = false;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
            else if (rdXemTheoThang.Checked == true)
            {
                dtpXemTheoNgay.Enabled = false;
                dtpXemTheoThang.Enabled = true;
                dtpTuNgay.Enabled = false;
                dtpDenNgay.Enabled = false;
            }
            else
            {
                dtpXemTheoNgay.Enabled = false;
                dtpXemTheoThang.Enabled = false;
                dtpTuNgay.Enabled = true;
                dtpDenNgay.Enabled = true;
            }
        }
    }
}
