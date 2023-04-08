using Buoi3TuorThiThu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3TuorThiThu.Services
{
    public class XeMayServices
    {
        private TutorCSharp3_ThiThub1Context _ThiThub1Context;
        public XeMayServices()
        {
            _ThiThub1Context = new();
        }

        public List<XeMay> GetAllXeMay()//Có thể dùng ViewModel Hoặc object
        {
            //var xemay = _ThiThub1Context.XeMays.ToList();
            //var loaixemay = _ThiThub1Context.LoaiXes.ToList();
            //var resutl = from xm in xemay
            //             join lxm in loaixemay
            //             on xm.IdLoaiXm equals lxm.Id
            //             select new
            //             {
            //                 Id = xm.Id,
            //                 Ten = xm.TenXe,
            //                 GiaNhap = xm.GiaNhap,
            //                 Mota = xm.MoTa,
            //                 Soluong = xm.SoLuong,
            //                 TenLoaiXe = lxm.TenLoaiXe
            //             };//Join để lấy được tên loại xe thông qua Id
            //return resutl;
            var xemay = _ThiThub1Context.XeMays.ToList();
            
            return xemay;
        }
        public bool CreateXe(XeMay xeMay)
        {
            try
            {
                if (xeMay.IdLoaiXm == 0)
                {
                    xeMay.IdLoaiXm = null;
                }
                var idmax = _ThiThub1Context.XeMays.ToList().Max(c => c.Id);//Lấy được Id lớn nhất
                xeMay.Id = idmax + 1;//Tăng id lớn nhất thêm 1
                _ThiThub1Context.XeMays.Add(xeMay);
                _ThiThub1Context.SaveChanges();//lưu ý nhớ SaveChanges
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateXe(XeMay xeMay)
        {
            try
            {
                var xemayupdate = _ThiThub1Context.XeMays.ToList().FirstOrDefault(c => c.Id == xeMay.Id);
                xemayupdate.TenXe = xeMay.TenXe;
                xemayupdate.MoTa = xeMay.MoTa;
                xemayupdate.GiaNhap = xeMay.GiaNhap;
                xemayupdate.IdLoaiXm = xeMay.IdLoaiXm;
                xemayupdate.SoLuong = xeMay.SoLuong;
                _ThiThub1Context.XeMays.Update(xemayupdate);
                _ThiThub1Context.SaveChanges();//lưu ý nhớ SaveChanges
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteXe(int id)
        {
            try
            {
                var xemayupdate = _ThiThub1Context.XeMays.ToList().FirstOrDefault(c => c.Id == id);
                _ThiThub1Context.Remove(xemayupdate);
                _ThiThub1Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
