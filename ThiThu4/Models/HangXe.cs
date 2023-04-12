using System;
using System.Collections.Generic;

namespace ThiThu4.Models
{
    public partial class HangXe
    {
        public HangXe()
        {
            XeMays = new HashSet<XeMay>();
        }

        public int Id { get; set; }
        public string TenHangXe { get; set; } = null!;

        public virtual ICollection<XeMay> XeMays { get; set; }
    }
}
