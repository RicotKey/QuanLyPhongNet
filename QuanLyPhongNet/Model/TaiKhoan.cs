namespace QuanLyPhongNet.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            NapTiens = new HashSet<NapTien>();
            SuDungs = new HashSet<SuDung>();
        }

        [Key]
        public int MaTK { get; set; }

        [StringLength(20)]
        public string TenTK { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        public int? SoTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NapTien> NapTiens { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuDung> SuDungs { get; set; }
    }
}
