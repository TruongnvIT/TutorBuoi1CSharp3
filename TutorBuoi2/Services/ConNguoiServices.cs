using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi2.Models;

namespace TutorBuoi2.Services
{
    internal class ConNguoiServices
    {
        private Buoi2TutorContext _context;
        public ConNguoiServices()
        {
            _context = new Buoi2TutorContext();
        }

        public dynamic GetConNguois()//object tự tìm hiểu
        {
            var connguois = _context.ConNguois.ToList();
            var chucvus = _context.ChucVus.ToList();
            var resutl = from cn in connguois
                         join cv in chucvus
                         on cn.IdChucVu equals cv.Id
                         select new
                         {
                             Id = cn.Id,
                             Ten = cn.Ten,
                             Tuoi = cn.Tuoi,
                             DiaChi = cn.DiaChi,
                             GioiTinh = cn.GioiTinh,
                             ChucVu = cv.ChucVu1
                         };
            return resutl;
        }
        
        public bool Create(ConNguoi conNguoi)
        {
            try
            {
                var idmax = _context.ConNguois.ToList().Max(c=>c.Id);//Tìm ra id lớn nhất và tăng lên 1
                conNguoi.Id = idmax + 1;
                _context.ConNguois.Add(conNguoi);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
        public bool Update(ConNguoi conNguoi)
        {
            try
            {
                var cn = _context.ConNguois.ToList().FirstOrDefault(c=>c.Id == conNguoi.Id);
                cn.Ten = conNguoi.Ten;
                cn.Tuoi = conNguoi.Tuoi;
                cn.DiaChi = conNguoi.DiaChi;
                cn.GioiTinh = conNguoi.GioiTinh;
                cn.IdChucVu = conNguoi.IdChucVu;

                _context.ConNguois.Update(cn);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var cn = _context.ConNguois.ToList().FirstOrDefault(c => c.Id == id);
                _context.ConNguois.Remove(cn);
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
