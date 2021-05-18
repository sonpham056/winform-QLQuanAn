namespace QuanLyQuanAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanKH")]
    public partial class TaiKhoanKH
    {
        [Key]
        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(20)]
        public string MK { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
