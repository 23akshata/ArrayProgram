using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class Length
    {
        public void ArrayLength()
        {
            int[] array = { 4, 6, 10, 9, 12, 5 ,7 };
            //Finding Length
            int arrayLength = array.Length;
            Console.WriteLine("Length of the array: "+arrayLength);
        }
    }
}
