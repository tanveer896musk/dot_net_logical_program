using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_program
{
    public class DuplicateString
    {
        public static void Duplicate(String[] args)
        {
            DuplicateString duplicateString = new DuplicateString();
            Console.WriteLine(duplicateString.dubString("tanveer"));
            Console.ReadLine(); 
        }
        public String removeduplicate(String message)
        {
            String result = "";
             for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                bool isduplicate = false;
                for (int j = 0; j < result.Length; j++)
                {
                    if (result[j] == c) 
                    {
                        isduplicate = true;
                        break;
                    }
                }
                if (!isduplicate) //false
                {
                    result = result+ c;
                }
            }
            return result;
        }
        public String dubString(String message)
        {
            String result = "";
            foreach (char c in message)
            {
                if (!result.Contains(c))
                {
                    result = result + c;
                }
            }
            return result;

        }
        
        
    }
}
