using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class numberPrintingasperuser
    {
        public static void factorialnum(String[] args)
        {
            Console.WriteLine("please enter the number for loop");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i <=a; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
