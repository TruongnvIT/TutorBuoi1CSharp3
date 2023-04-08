using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3TuorThiThu
{
    public class validate
    {
        public bool CheckGia(string gia)//Có thể dùng regex để check
        {
			try
			{
				var giaNhap = Convert.ToDouble(gia);
				if ((int)giaNhap - giaNhap == 0 && giaNhap > 0)//Check xem có phải số nguyên không
				{
                    return true;
                }
				return false;
			}
			catch (Exception)
			{
				return false;
			}
        }
    }
}
