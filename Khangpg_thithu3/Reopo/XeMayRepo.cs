using Khangpg_thithu3.Models;
using Khangpg_thithu3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khangpg_thithu3.Reopo
{
    public class XeMayRepo
    {
        private readonly XeMaySerrvices _xeMaySerrvices;
        public XeMayRepo()
        {
            _xeMaySerrvices = new();
        }

        public List<XeMay> GetXeMays()
        {
            return _xeMaySerrvices.GetXeMays();
        }

        public string Create(XeMay xeMay)
        {
            if (_xeMaySerrvices.Create(xeMay))
            {
                return "Thêm xe thành công";
            }
            return "Thêm xe thất bại;";
        }

        public string Update(XeMay xeMay)
        {
            if (_xeMaySerrvices.Update(xeMay))
            {
                return "Cập nhật xe thành công";
            }
            return "Cập nhật xe thất bại;";
        }

        public string Delete(int id)
        {
            if (_xeMaySerrvices.Delete(id))
            {
                return "Xóa xe thành công";
            }
            return "Xóa xe thất bại;";
        }
    }
}
