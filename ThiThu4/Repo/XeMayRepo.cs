using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu4.Models;
using ThiThu4.Services;

namespace ThiThu4.Repo
{
    public class XeMayRepo
    {
        private XeMayServices _xeMayServices;
        public XeMayRepo()
        {
            _xeMayServices = new();
        }
        public List<XeMay> GetAll()//Nếu dùng join thì đổi kiểu trả về thành dynamic
        {
            return _xeMayServices.GetAll();
        }
        //public dynamic GetAll(string search)
        //{
        //    return _xeMayServices.GetAll(search);
        //}
        public string Create(XeMay xeMay)
        {
            if (_xeMayServices.Create(xeMay))
            {
                return "Thêm mới thành công";
            }
            return "Tạo mới thất bại";
        }
        public string Update(XeMay xeMay)
        {
            if (_xeMayServices.Update(xeMay))
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
        }
        public string Delete(int Id)
        {
            if (_xeMayServices.Delete(Id))
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
