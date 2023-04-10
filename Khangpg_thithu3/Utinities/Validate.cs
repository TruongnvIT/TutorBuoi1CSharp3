using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khangpg_thithu3.Utinities
{
    public class Validate
    {
        public bool CheckGia(string gia)
        {
			try
			{
				if (Convert.ToInt32(gia) > 0 && !string.IsNullOrEmpty(gia))
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
