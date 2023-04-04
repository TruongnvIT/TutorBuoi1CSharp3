using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi1CSharp3.Models;

namespace TutorBuoi1CSharp3.Services
{
    internal class NguoiDungServices
    {
        private Buoi1TutorContext _context;
        public NguoiDungServices()
        {
            _context = new Buoi1TutorContext();
        }

        public List<NguoiDung> GetAll()
        {
            return _context.NguoiDungs.ToList();
        }
        public bool AddNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                _context.NguoiDungs.Add(nguoiDung);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                var resutl = _context.NguoiDungs.ToList().FirstOrDefault(x => x.Id == nguoiDung.Id);
                resutl.Ten = nguoiDung.Ten;
                resutl.GiớiTính = nguoiDung.GiớiTính;
                _context.NguoiDungs.Update(resutl);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNguoiDung(int id)
        {
            try
            {
                var resutl = _context.NguoiDungs.ToList().FirstOrDefault(x => x.Id == id);
                _context.NguoiDungs.Remove(resutl);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
