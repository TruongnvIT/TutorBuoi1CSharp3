﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiThu4.Utilities
{
    public class Validated
    {
        public bool Check(string gia)
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
