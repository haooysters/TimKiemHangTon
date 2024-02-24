using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace TimKiemHangTon.Models
{
    public partial class HangTon
    {
        [Key]
        public string InspectionNo { get; set; }
        public string MaHang { get; set; }
        public int? SoLuong { get; set; }
    }
}
