using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class Armstrong
    {
        public static void armstrongnumber(String[] args)
        {
            int a = 370;
            int result = 0;
            int count = 0;
            int z = a;
            int b = a;
            while (z > 0)
            {
                z = z / 10;
                count++;
            }
            while (b > 0)
            {
                int d = b % 10;
                result = result + power(d, count);
                b = b / 10;
            }
            if (result == a)
            {
                Console.WriteLine("ArmStrong Number");
            }
            else
            {
                Console.WriteLine("no armstrong");
            }

        }
       /* public int armstrongnumbers(int a)
        {
            int result = 0;
            int count = 0;
            int z = a;
            int b = a;
            while (z > 0){
                z = z / 10;
                count++;
            }
            while(b > 0)
            {
                int d = b % 10;
                result = result + power(d, count);
                b = b / 10;
            }

            return result;
        }*/
        public static int power(int num, int poer)
        {
            int result = 1;
            for (int i = 1; i <= poer; i++)
            {
                result = result * num;
            }
         return result;   
        }
    }
}
