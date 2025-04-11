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
            Console.ReadLine(); 
        }
        static void NoloopPrime(int a)
        {
            int count = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("Is Prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
