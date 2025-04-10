using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class PalidroneNumber
    {
        public static void palin(String[] args)
        {
            
            Console.WriteLine("Please Enter Your Number");
            int a1 = int.Parse(Console.ReadLine());
            PalidroneNumber palidroneNumber = new PalidroneNumber();
            Console.WriteLine(palidroneNumber.palinnum(a1));
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine(palidroneNumber.palinnum(a2));
        }
        public String palinnum(int a)
        {
            int temp = a;
            int ans = 0;
            while (a > 0)
            {
                int d = a % 10;
                ans = ans * 10 + d;
                a = a / 10;
            }
            if (temp == ans)
            {
                return "palindrone ";
            }
            else
            {
                return "not palindrone";
            }
        }
    }
}

