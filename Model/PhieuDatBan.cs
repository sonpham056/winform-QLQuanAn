namespace QuanLyQuanAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuDatBan")]
    public partial class PhieuDatBan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string MaKH { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string MaBan { get; set; }

        [StringLength(20)]
        public string TrangThaiDatCoc { get; set; }

        public DateTime? NgayDat { get; set; }

        public int? Status { get; set; }

        public virtual Ban Ban { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
