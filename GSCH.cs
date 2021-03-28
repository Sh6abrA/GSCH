using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GSCH
{
    class GSCH
    {
        public int[] gs;
        public GSCH(int[] gsch, int bit2)
        {
            GPSCH gp = new GPSCH(bit2, 0);
            for (int i = 0; i < gsch.Length; i++)
            {
                int tmp = 0;
                do
                {
                    gp = new GPSCH(bit2, gp.x);
                }
                while (gp.x >= gsch.Length);
                tmp = gsch[gp.x];
                gsch[gp.x] = gsch[i];
                gsch[i] = tmp;
            }
            gs = gsch;
        }
    }
}
