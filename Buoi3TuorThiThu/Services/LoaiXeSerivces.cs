using Buoi3TuorThiThu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3TuorThiThu.Services
{
    public class LoaiXeSerivces
    {
        private TutorCSharp3_ThiThub1Context _ThiThub1Context;
        public LoaiXeSerivces()
        {
            _ThiThub1Context = new();
        }

        public List<LoaiXe> GetLoaiXes()
        {
            return _ThiThub1Context.LoaiXes.ToList();
        }
    }
}
