using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class SwapNumber
    {
        public static void Swapping(String[] args)
        {
            int a = 210;
            int b = 350;
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("swap value of a is before 210 after "+a+" b before 350 after "+b); ;
        }
    }
}
