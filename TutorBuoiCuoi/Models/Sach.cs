using System;
using System.Collections.Generic;

namespace TutorBuoiCuoi.Models
{
    public partial class Sach
    {
        public int Id { get; set; }
        public string TenSach { get; set; } = null!;
        public string? NhaXb { get; set; }
        public bool TrangThai { get; set; }
        public string Ma { get; set; } = null!;
        public int GiaSach { get; set; }
    }
}
