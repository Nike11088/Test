using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] a = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k' };

            Console.WriteLine("*****WELCOME!*****");
            for (int i = 0; i < 10; i++)
                Console.WriteLine("{0} - {1}", i, a[i]);
            Console.ReadLine();
        }
    }
}
