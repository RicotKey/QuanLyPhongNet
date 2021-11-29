using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongNet.Model
{
    class ReportDoAn
    {

        public int MaNapTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNap { get; set; }

        public string TenTK { get; set; }

        public long? SoTienNap { get; set; }
    }
}
