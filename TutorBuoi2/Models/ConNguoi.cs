using System;
using System.Collections.Generic;

namespace TutorBuoi2.Models
{
    public partial class ConNguoi
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public int Tuoi { get; set; }
        public string DiaChi { get; set; } = null!;
        public string GioiTinh { get; set; } = null!;
        public int IdChucVu { get; set; }

        public virtual ChucVu IdChucVuNavigation { get; set; } = null!;
    }
}
