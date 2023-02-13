using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class NegativeElements
    {
        public void Negative()
        {
            int[] num = { -23, 45, 13, -32, -43, 10 };
            for (int i= 0; i< num.Length; i++)
            {
                if (num[i] < 0)
                    Console.WriteLine("The Negetive Number is " + num[i]);
            }
        }
    }
}
