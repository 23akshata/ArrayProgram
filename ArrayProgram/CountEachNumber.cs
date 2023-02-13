using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class CountEachNumber
    {
         public void Number()
         {
            int[] num = { 5, 23, 6, 9, 10, 43, 34, 30, 8 };
            int count = 0;

            count = num.Count();
            Console.WriteLine("The Count Each numbers:" +count);

         
         }
    }
}
