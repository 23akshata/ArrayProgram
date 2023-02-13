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
            Console.WriteLine("1:ArrayLength \n 2.MinMaxNumbers \n 3:SumOfArray \n 4:NegativeElements \n 5:CountEachNumber");
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

                case 3:
                    SumOfArray sum = new SumOfArray();
                    sum.Sum();
                    break;

                case 4:
                    NegativeElements elements = new NegativeElements();
                    elements.Negative();
                    break;

                case 5:
                    CountEachNumber number = new CountEachNumber();
                    number.Number();
                    break;
            }
            Console.ReadLine();
        }

        
    }
}
