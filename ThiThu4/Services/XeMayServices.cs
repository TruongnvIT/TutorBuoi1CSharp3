using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu4.Models;

namespace ThiThu4.Services
{
    public class XeMayServices
    {
        private ThiThu4Context _context;
        public XeMayServices()
        {
            _context = new();//tương đương new ThiThu4Context();
        }

        //public dynamic GetAll()
        //{
        //    var xemay = _context.XeMays.ToList();
        //    var hangxe = _context.HangXes.ToList();
        //    var resutl = from xe in xemay
        //                 join hang in hangxe
        //                 on xe.IdHangXe equals hang.Id
        //                 select new
        //                 {
        //                     Id = xe.Id,
        //                     Ten = xe.TenXe,
        //                     Ma = xe.MaXe,
        //                     Gia = xe.GiaBan,
        //                     Hang = hang.TenHangXe
        //                 };
        //    return resutl;
        //}
        public List<XeMay> GetAll() //Nếu dùng join thì đổi kiểu trả về thành dynamic
        {
            var xemay = _context.XeMays.ToList();/*.Where(c=>c.TenXe.Contains(search));*/
            //var hangxe = _context.HangXes.ToList();
            //var resutl = from xe in xemay
            //             join hang in hangxe
            //             on xe.IdHangXe equals hang.Id
            //             select new
            //             {
            //                 Id = xe.Id,
            //                 TenXe = xe.TenXe,
            //                 MaXe = xe.MaXe,
            //                 GiaBan = xe.GiaBan,
            //                 Hang = hang.TenHangXe
            //             };
            return xemay;
        }
        public bool Create(XeMay xeMay)
        {
            try
            {
                int idmax = 0;
                if (_context.XeMays.ToList().Count > 0)
                {
                    idmax = _context.XeMays.ToList().Max(c => c.Id);
                }
                xeMay.Id = idmax + 1; 
                _context.XeMays.Add(xeMay);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Update(XeMay xeMay)
        {
            try
            {
                var xe = _context.XeMays.ToList().FirstOrDefault(c => c.Id == xeMay.Id);

                xe.TenXe = xeMay.TenXe;
                xe.GiaBan = xeMay.GiaBan;
                xe.IdHangXe = xeMay.IdHangXe;

                _context.XeMays.Update(xe);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool Delete(int Id)
        {
            try
            {
                var xe = _context.XeMays.ToList().FirstOrDefault(c => c.Id == Id);
                _context.XeMays.Remove(xe);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
