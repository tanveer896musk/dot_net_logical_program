using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace logical_program
{
    public class Pyramid
    {
        public static void pramid(String[] args)
        {
            Console.WriteLine("please enter the length of pyramid");
            int rows = int.Parse(Console.ReadLine());  

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" "); 
                }

               
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*"); 
                }

                
                Console.WriteLine();
            }


        }

    }
}



       

