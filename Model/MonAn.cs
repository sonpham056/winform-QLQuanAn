namespace QuanLyQuanAn.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonAn")]
    public partial class MonAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonAn()
        {
            CTBans = new HashSet<CTBan>();
        }

        [Key]
        [StringLength(10)]
        public string MaMA { get; set; }

        [StringLength(50)]
        public string TenMA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GiaTien { get; set; }

        public int? Status { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLoaiMonAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBan> CTBans { get; set; }

        public virtual LoaiMonAn LoaiMonAn { get; set; }
    }
}
