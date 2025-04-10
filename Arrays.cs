using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class Arrays
    {
        public static void arr(string[] args)
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("hello this is tanveer");
            Console.WriteLine(String.Join(", ", array.ToArray()));
            Console.WriteLine(array[0]);
            LinkedList <String > list = new LinkedList<String>();
            list.AddFirst("Collegen");
            Console.WriteLine(list);
        }
        
    }
}
