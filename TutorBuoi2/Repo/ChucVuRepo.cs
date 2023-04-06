using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi2.Models;
using TutorBuoi2.Services;

namespace TutorBuoi2.Repo
{
    internal class ChucVuRepo
    {
        private ChucVuServices _services;

        public ChucVuRepo()
        {
            _services = new ChucVuServices();
        }

        public List<ChucVu> GetChucVus()
        {
            return _services.GetChucVus();
        }
    }
}
