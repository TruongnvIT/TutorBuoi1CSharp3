using Buoi3TuorThiThu.Models;
using Buoi3TuorThiThu.Services;

namespace Buoi3TuorThiThu.Repo
{
    public class XeMayRepo
    {
        private XeMayServices _xeMayServices;
        public XeMayRepo()
        {
            _xeMayServices = new XeMayServices();
        }

        public List<XeMay> GetAllXeMay()//Có thể dùng ViewModel Hoặc object
        {
           return _xeMayServices.GetAllXeMay();
        }
        public string CreateXe(XeMay xeMay)
        {
            var add = _xeMayServices.CreateXe(xeMay);
            if (add)
            {
                return "Thêm mới thành công";
            }
            return "Thêm mới thất bại";
        }
        public string UpdateXe(XeMay xeMay)
        {
            var update = _xeMayServices.UpdateXe(xeMay);
            if (update)
            {
                return "Cập nhật thành công";
            }
            return "Cập nhật thất bại";
        }

        public string DeleteXe(int id)
        {
            var delete = _xeMayServices.DeleteXe(id);
            if (delete)
            {
                return "Xóa thành công";
            }
            return "Xóa thất bại";
        }
    }
}
