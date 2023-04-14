using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoiCuoi.Models;

namespace TutorBuoiCuoi.Services
{
    public class SachServices
    {

        private ThiThuCSharp3BuoiCuoiContext _context;
        public SachServices()
        {
            _context = new();
        }

        public List<Sach> GetAll()
        {
            return _context.Sachs.ToList();
        }

        public bool Create(Sach sach)
        {
            try
            {
                int idnew = 0;
                if (_context.Sachs.ToList().Count > 0)
                {
                    idnew = _context.Sachs.ToList().Max(c => c.Id);
                }
                sach.TenSach = sach.TenSach.Trim();
                string ma = "";
                for (int i = 0; i < sach.TenSach.Length; i++)
                {
                    if (i == 0)
                    {
                        ma = sach.TenSach.Substring(i, 1);
                    }
                    if (sach.TenSach[i].ToString() == " ")
                    {
                        ma = ma + sach.TenSach.Substring(i, 1);
                    }
                }
                sach.Ma = ma;
                sach.Id = idnew + 1;
                _context.Sachs.Add(sach);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Update(Sach sach)
        {
            try
            {
                var resutl = _context.Sachs.ToList().FirstOrDefault(c => c.Id == sach.Id);
                resutl.TenSach = sach.TenSach;
                resutl.GiaSach = sach.GiaSach;
                resutl.NhaXb = sach.NhaXb;
                resutl.TrangThai = sach.TrangThai;
                _context.Sachs.Update(resutl);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                var resutl = _context.Sachs.ToList().FirstOrDefault(c => c.Id == id);
                _context.Sachs.Remove(resutl);
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
