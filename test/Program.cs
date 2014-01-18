using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mojaTablica = new int[1000];


            for (int i = 0; i < mojaTablica.Length; i++)
            {
                mojaTablica[i] = i;
                Console.WriteLine(mojaTablica[i]);
              
            }
            //tylko koment
            Console.ReadLine();
        }
              
        
    }
}
