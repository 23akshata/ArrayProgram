using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class MinMaxNumbers
    {
        public void Numbers()
        {
            int[] array = { 12, 23, 45, 43, 50, 54 };
            Console.WriteLine("Minimum Number is :" + array.Min());
            Console.WriteLine("Maximum Number is :" + array.Max());
        }
    }
}
