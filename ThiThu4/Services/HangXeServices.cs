using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu4.Models;

namespace ThiThu4.Services
{
    public class HangXeServices
    {
        private ThiThu4Context _thiThu4Context;
        public HangXeServices()
        {
            _thiThu4Context = new();
        }

        public List<HangXe> GetAll()
        {
            return _thiThu4Context.HangXes.ToList();
        }
    }
}
