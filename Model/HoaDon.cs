namespace QuanLyQuanAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDon()
        {
            CTBans = new HashSet<CTBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaHD { get; set; }

        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TongTien { get; set; }

        [StringLength(10)]
        public string ThanhToan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBan> CTBans { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
