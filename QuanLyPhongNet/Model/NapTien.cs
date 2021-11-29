namespace QuanLyPhongNet.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NapTien")]
    public partial class NapTien
    {
        [Key]
        public int MaNapTien { get; set; }

        public int? MaTK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNap { get; set; }

        public long? SoTienNap { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
