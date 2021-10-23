using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i > 2; i -= 3)
            {
                Console.WriteLine(i + " - 3 = " + (i - 3));
                System.Threading.Thread.Sleep(100);
            }

        }
    }
}
