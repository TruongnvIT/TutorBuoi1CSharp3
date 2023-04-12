using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiThu4.Models;
using ThiThu4.Services;

namespace ThiThu4.Repo
{
    public class HangXRepo
    {
        private HangXeServices _services;
        public HangXRepo()
        {
            _services = new();
        }

        public List<HangXe> GetAll()
        {
            return _services.GetAll();
        }
    }
}
