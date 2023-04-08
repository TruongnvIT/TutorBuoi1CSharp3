using Buoi3TuorThiThu.Models;
using Buoi3TuorThiThu.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3TuorThiThu.Repo
{
    public class LoaiXeRepo
    {
        private LoaiXeSerivces _loaiXeSerivces;
        public LoaiXeRepo()
        {
            _loaiXeSerivces = new();
        }
        public List<LoaiXe> GetLoaiXes()
        {
            return _loaiXeSerivces.GetLoaiXes();
        }
    }
}
