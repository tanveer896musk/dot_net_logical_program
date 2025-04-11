using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class ParentClass
    {
        public virtual int add(int a, int b)
        {
            return a + b;
        }
    }
    public class Childclass : ParentClass
    {
        public override int add(int a, int b)
        {
            int c = base.add(a, b);
            Console.WriteLine("This is Normal Function : "+c);
            return a * b;
        }
    }
    public class Overriding 
    {
        public static void Override(string[] args)
        {
            Console.WriteLine("please enter the value of a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the value of b ");
            int b = int.Parse(Console.ReadLine());
            Childclass overriding = new Childclass();
            Console.WriteLine("this is overriding "+overriding.add(a,b));
        }
        
    }
   
}
