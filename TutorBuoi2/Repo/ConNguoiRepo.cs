using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi2.Models;
using TutorBuoi2.Services;

namespace TutorBuoi2.Repo
{
    internal class ConNguoiRepo
    {
        private ConNguoiServices _services;

        public ConNguoiRepo()
        {
            _services = new ConNguoiServices();
        }

        public dynamic GetConNguois()
        {
            return _services.GetConNguois();
        }

        public string Create(ConNguoi conNguoi)
        {
            try
            {
                _services.Create(conNguoi);
                return "Tạo mới thành công";
            }
            catch (Exception)
            {
                return "Tạo mới thất bại";
            }
        }

        public string Update(ConNguoi conNguoi)
        {
            try
            {
                _services.Update(conNguoi);
                return "Cập nhật thành công";
            }
            catch (Exception)
            {
                return "Cập nhật thất bại";
            }
        }

        public string Delete(int id)
        {
            try
            {
                _services.Delete(id);
                return "Xóa thành công";
            }
            catch (Exception)
            {
                return "Xóa thất bại";
            }
        }
    }
}
