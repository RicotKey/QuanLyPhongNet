namespace QuanLyPhongNet.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SuDung")]
    public partial class SuDung
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string SoMay { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTK { get; set; }

        public int? TienSuDung { get; set; }

        [StringLength(3)]
        public string TrangThai { get; set; }

        public virtual May May { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
