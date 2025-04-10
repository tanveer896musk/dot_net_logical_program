using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class Primenumber
    {
        public static void primenum(String[] args)
        {
            
            for (int i = 2; i <= 100; i++)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    
                    if (i%j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i + " is a prime number");
                }
            }
        }
    }
}
