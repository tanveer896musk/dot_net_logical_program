using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class FactorialnumberPrinting
    {
        public static void factorialnum(String[] args)
        {
            Console.WriteLine("Enter the Value for Factorial");
            int a = int.Parse(Console.ReadLine());
            FactorialnumberPrinting factorialnumberPrinting = new FactorialnumberPrinting();
            Console.WriteLine(factorialnumberPrinting.factorialnumer(a));
        }
        public int factorialnumer(int n)
        {
            int ans = 1;
            for (int i = 1; i <= n; i++)
            {
                ans = ans * i;
            }
            return ans;
        }
    }
}
