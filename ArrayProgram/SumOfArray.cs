using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class SumOfArray
    {
        public void Sum()
        {
            int[] array = new int[10];
            int i, sum = 0;

            for (i=0; i<array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum:");
        }
    }
}
