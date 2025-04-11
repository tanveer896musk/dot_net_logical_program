using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public abstract class AbstractClassexample
    {
        int a;
        int b;
      public abstract void Dummyfunction();
    }
    public class AbstractClass : AbstractClassexample
    {
        int a = 11;
        int b = 32;
    public override void Dummyfunction()
        {
            Console.WriteLine("hello this is abtract function ");
        }
        public static void AbstarctMain(String[] args)
        {
            AbstractClass abstractClass = new AbstractClass();
            Console.WriteLine("this is the value of A and B" + abstractClass.a + " " + abstractClass.b);
           abstractClass.Dummyfunction();
        }
    }
}
