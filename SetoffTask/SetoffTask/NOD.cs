using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.SetoffTask
{
    class NOD
    {
        int firstNum;
        int secNum;
        public NOD(int a, int b)
        {
            firstNum = a;
            secNum = b;
        }

        public static int FindNod (int firstNum, int secNum)
        {
            while (secNum!=0)
            {
                int temp = secNum;
                secNum = firstNum % secNum;
                firstNum = temp;
            }
            return firstNum;
        }
        


    }
}
