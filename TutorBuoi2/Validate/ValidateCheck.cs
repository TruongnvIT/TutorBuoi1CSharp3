using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorBuoi2.Validate
{
    public class ValidateCheck
    {
        public ValidateCheck()
        {
            
        }

        //Check xem nếu so convert được qua số thì trả về true nếu không thể convert(bị lỗi) sẽ nhảy vào catch và trả về false
        public bool CheckSo(string so)
        {
            try
            {
                Convert.ToInt32(so);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
