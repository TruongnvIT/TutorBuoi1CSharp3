using System;
using System.Collections.Generic;

namespace Buoi3TuorThiThu.Models
{
    public partial class XeMay
    {
        public int Id { get; set; }
        public string TenXe { get; set; } = null!;
        public string? MoTa { get; set; }
        public int GiaNhap { get; set; }
        public int SoLuong { get; set; }
        public int? IdLoaiXm { get; set; }

        public virtual LoaiXe? IdLoaiXmNavigation { get; set; }
    }
}
