using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class StringManipulation
    {
        public static void Manipulation(String[] args)
        {
            String name = "Tanveer Sayyed ";
            String crippleString = " kl";




            bool Comapring = name.StartsWith("Tanveer"); //return bool

            
            bool Comapring1 = name.EndsWith("Tanveer"); //return bool
            Console.WriteLine($"!!!!!!!!!!!{Comapring1}111111111111111111{Comapring}");

            bool chmod = name.Contains("say");         //return bool
            Console.WriteLine(chmod);

            int bd = name.IndexOf("Say");                   //return int and index of start string character
            Console.WriteLine(bd);

            int bd1 = name.LastIndexOf("y");
            Console.WriteLine(bd1);


            bool ba  =  String.IsNullOrEmpty(crippleString);
            Console.WriteLine(ba);



            String.Equals(name, crippleString); name.Equals(name);

            String.Compare(name, crippleString);

            int ban = name.CompareTo(crippleString);
            Console.WriteLine(ban+" this bannnnnnnnn");



            name = name.ToLower();

            Console.WriteLine(name);
            name = name.ToUpper();

            Console.WriteLine(name);
            name = name.Trim();
            Console.WriteLine(name);


            if (name.Equals("Raju Bhaiya"))
            {
                Console.WriteLine("Hello Message");
            }
            else {
                Console.WriteLine("Transfer");
            }
            name = name.Insert(14, " Is Programmer");
            Console.WriteLine(name);
            
            int bol = String.Compare("Tanveer", "veer"); // this String.Compare return int.
            Console.WriteLine(bol);
        }
    }
}
