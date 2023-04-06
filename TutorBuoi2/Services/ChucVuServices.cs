using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi2.Models;

namespace TutorBuoi2.Services
{
    internal class ChucVuServices
    {
        private Buoi2TutorContext _context;
        public ChucVuServices()
        {
            _context = new Buoi2TutorContext();
        }
        public List<ChucVu> GetChucVus()
        {
            return _context.ChucVus.ToList();
        }
    }
}
