using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class ReverseString
    {
        public static void Stringreverse(String[] args)
        {
            ReverseString reverseString = new ReverseString();
            Console.WriteLine(reverseString.reverse("Tanveer"));
        }
        public String reverse(String message) {
            String Result = "";
            for (int i = message.Length-1; i >= 0; i--)
            {
                char c = message[i];
                Result = Result+ c;
            }
            return Result;
        }
    }
}
