using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoiCuoi.Models;
using TutorBuoiCuoi.Services;

namespace TutorBuoiCuoi.Repo
{
    public class SachRepo
    {
        private SachServices _sachServices;
        public SachRepo()
        {
            _sachServices = new();
        }
        public List<Sach> GetAll()
        {
            return _sachServices.GetAll();
        }

        public string Create(Sach sach)
        {
            if (_sachServices.Create(sach))
            {
                return "Thành công";
            }
            return "Thất bại";
        }

        public string Update(Sach sach)
        {
            if (_sachServices.Update(sach))
            {
                return "Thành công";
            }
            return "Thất bại";
        }
        public string Delete(int id)
        {
            if (_sachServices.Delete(id))
            {
                return "Thành công";
            }
            return "Thất bại";
        }
    }
}
