using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SetoffTask
{
    class NOK
    {
        public static int FindNok (int a, int b)
        {
            return a / NOD.FindNod(a, b) * b;
        }
    }
}
