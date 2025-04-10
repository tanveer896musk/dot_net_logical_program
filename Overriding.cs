using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class overload
    {
        public virtual int add(int a, int b)
        {
            return a + b;
        }
    }

    public class Overriding : overload
    {
        public override int add(int a, int b)
        {
            return a * b;
        }
        public static void Override(string[] args)
        {
            Console.WriteLine("please enter the value of a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the value of b ");
            int b = int.Parse(Console.ReadLine());
            overload overriding = new Overriding();
            Console.WriteLine("this is overriding "+overriding.add(a,b));
           
        }
        
    }

    
}
