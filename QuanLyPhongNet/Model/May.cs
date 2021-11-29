namespace QuanLyPhongNet.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("May")]
    public partial class May
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public May()
        {
            SuDungs = new HashSet<SuDung>();
        }

        [Key]
        [StringLength(5)]
        public string SoMay { get; set; }

        [StringLength(20)]
        public string ThongTin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuDung> SuDungs { get; set; }
    }
}
