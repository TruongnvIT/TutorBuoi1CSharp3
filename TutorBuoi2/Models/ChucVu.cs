using System;
using System.Collections.Generic;

namespace TutorBuoi2.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            ConNguois = new HashSet<ConNguoi>();
        }

        public int Id { get; set; }
        public string ChucVu1 { get; set; } = null!;

        public virtual ICollection<ConNguoi> ConNguois { get; set; }
    }
}
