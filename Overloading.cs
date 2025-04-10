using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class Overloading
    {
        public static void Overload(string[] args)
        {
            Console.WriteLine("please enter the value of a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the value of b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the value of c");
            int c = int.Parse(Console.ReadLine());
            Overloading overloading = new Overloading();
            Console.WriteLine("overloaded a and b : "+overloading.add(a,b));
            Console.WriteLine("overloaded a and b : " + overloading.add(a, b,c));
            Console.ReadLine();
        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b,int c)
        {
            return a + b  + c ;
        }
    }

}

