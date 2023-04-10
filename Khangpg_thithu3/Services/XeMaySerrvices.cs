using Khangpg_thithu3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khangpg_thithu3.Services
{
    public class XeMaySerrvices
    {
        private readonly ThiThu3Context _thiThu3Context;
        public XeMaySerrvices()
        {
            _thiThu3Context = new();
        }

        public List<XeMay> GetXeMays()
        {
            return _thiThu3Context.XeMays.ToList();
        }

        public bool Create(XeMay xeMay)
        {
            try
            {
                int idmax = 0;
                if (_thiThu3Context.XeMays.ToList().Count > 0)
                {
                    idmax = _thiThu3Context.XeMays.ToList().Max(c => c.Id);

                }
                xeMay.Id = idmax + 1;
                _thiThu3Context.XeMays.Add(xeMay);
                _thiThu3Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(XeMay xeMay)
        {
            try
            {
                var xemay = _thiThu3Context.XeMays.ToList().FirstOrDefault(c => c.Id == xeMay.Id);
                xemay.MaXe = xeMay.MaXe;
                xemay.TenXe = xeMay.TenXe;
                xemay.GiaBan = xeMay.GiaBan;
                xemay.TrangThai = xeMay.TrangThai;
                _thiThu3Context.XeMays.Update(xemay);
                _thiThu3Context.SaveChanges();
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
                var xemay = _thiThu3Context.XeMays.ToList().FirstOrDefault(c => c.Id == id);
                _thiThu3Context.XeMays.Remove(xemay);
                _thiThu3Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
