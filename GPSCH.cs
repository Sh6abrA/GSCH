using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSCH
{
    class GPSCH
    {


        public int const1 = 5;
        public int const2 = 1;
        public int x;
        public GPSCH(int bit, int y)
        {
            Random random = new Random();

          

            x = y;
            x = (x * const1 + const2) % bit;
        }

    }
}
