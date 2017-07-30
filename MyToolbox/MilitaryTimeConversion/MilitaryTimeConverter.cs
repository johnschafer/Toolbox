using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryTimeConversion
{
    public class MilitaryTimeConverter
    {
        public static void Main()
        {

        }

        public void ConvertTime(int p)
        {
            if(p < 0 || p > 23)
            {
                throw new IndexOutOfRangeException("Not a valid time, please enter a valid time between 0 and 23.");
            }
        }
    }
}
