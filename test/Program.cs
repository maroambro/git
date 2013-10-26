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
            int x, y;
            string t;
            Console.Write("x: ");
            t = Console.ReadLine();
            x = int.Parse(t);

            Console.Write("y: ");
            t = Console.ReadLine();
            y = int.Parse(t);

            if (x > y)
                Console.WriteLine("{0}>{1}", x, y);
            else if (x < y)
                Console.WriteLine("{0}<{1}", x, y);
            else
                Console.WriteLine("{0}={1}", x, y);

            Console.ReadLine();
        }
    }
}
