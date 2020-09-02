using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SetoffTask
{
    class BinaryPow
    {
        public static int CalculatePow(int number, int pow)
        {
            if (pow == 0)
                return 1;
            else if (pow % 2 == 1)
                return CalculatePow(number, pow - 1) * number;
            else
            {
                int temp = CalculatePow(number, pow / 2);
                return temp * temp;
            }

            
        } 
    }
}
