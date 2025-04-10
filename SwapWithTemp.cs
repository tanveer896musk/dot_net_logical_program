using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class SwapWithTemp
    {
        public static void swapping(String[] args)
        {
            int tempt = 0;
            int a = 56;
            int b = 79;

            tempt = b;
            b = a;
            a = tempt;

            Console.WriteLine("swapped a and b value"+a+" "+b);
        }
    }
}
