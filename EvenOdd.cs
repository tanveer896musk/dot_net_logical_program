using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class EvenOdd
    {
        public static void Evenodd(String[] args) {

            Console.WriteLine("Please enter the number to chk its even or odd ");
            Int32 a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
    }
}
