using System;
using System.Collections.Generic;

namespace Buoi3TuorThiThu.Models
{
    public partial class LoaiXe
    {
        public LoaiXe()
        {
            XeMays = new HashSet<XeMay>();
        }

        public int Id { get; set; }
        public string TenLoaiXe { get; set; } = null!;

        public virtual ICollection<XeMay> XeMays { get; set; }
    }
}
