using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorBuoi1CSharp3.Models;
using TutorBuoi1CSharp3.Services;

namespace TutorBuoi1CSharp3.Repo
{
    internal class NguoiDungRepo
    {
        private NguoiDungServices _nguoiDungServices;
        public NguoiDungRepo()
        {
            _nguoiDungServices = new NguoiDungServices();
        }

        public List<NguoiDung> GetAll()
        {
            return _nguoiDungServices.GetAll();
        }

        public string AddNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                _nguoiDungServices.AddNguoiDung(nguoiDung);
                return "Thêm mới thành công";
            }
            catch (Exception)
            {
                return "Thêm mới thất bại";
            }
        }
        public string UpdateNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                _nguoiDungServices.UpdateNguoiDung(nguoiDung);
                return "Cập nhật thành công";
            }
            catch (Exception)
            {
                return "Cập nhật thất bại";
            }
        }

        public string DeleteNguoiDung(int id)
        {
            try
            {
                _nguoiDungServices.DeleteNguoiDung(id);
                return "Xóa thành thành công";
            }
            catch (Exception)
            {
                return "Xóa thất bại";
            }
        }
    }
}
