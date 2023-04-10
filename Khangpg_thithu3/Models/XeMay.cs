using System;
using System.Collections.Generic;

namespace Khangpg_thithu3.Models
{
    public partial class XeMay
    {
        public int Id { get; set; }
        public string MaXe { get; set; } = null!;
        public string TenXe { get; set; } = null!;
        public int GiaBan { get; set; }
        public bool TrangThai { get; set; }
    }
}
