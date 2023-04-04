using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorBuoi1CSharp3
{
    internal class Validate
    {
        public Validate()
        {
            
        }
        public bool CheckNull(string text)
        {
            return text.Trim() == "" ? false : true;
        }
    }
}
