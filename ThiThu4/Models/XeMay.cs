using System;
using System.Collections.Generic;

namespace ThiThu4.Models
{
    public partial class XeMay
    {
        public int Id { get; set; }
        public string MaXe { get; set; } = null!;
        public string TenXe { get; set; } = null!;
        public int GiaBan { get; set; }
        public int IdHangXe { get; set; }

        public virtual HangXe IdHangXeNavigation { get; set; } = null!;
    }
}
