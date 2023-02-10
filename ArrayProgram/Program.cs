using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProgram
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("1:ArrayLength \n 2.MinMaxNumbers");
            Console.WriteLine("Enter Your Choice:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Length arrayLength = new Length();
                    arrayLength.ArrayLength();
                    break;

                case 2:
                    MinMaxNumbers numbers = new MinMaxNumbers();
                    numbers.Numbers();
                    break;


            }
            Console.ReadLine();
        }

        
    }
}
