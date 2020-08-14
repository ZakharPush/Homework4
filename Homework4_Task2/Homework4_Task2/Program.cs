using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            bool A = true;
            bool B = false;
            if (A | B)
                Console.WriteLine(" A | B {0} ", A | B);
            else Console.WriteLine("A | B {0} ", A | B);

            if (!(!A & !B))
                Console.WriteLine("!(!A & !B) {0} ", !(!A & !B));
            else Console.WriteLine("!(!A & !B) {0} ", !(!A & !B));
            Console.ReadKey();
        }
    }
}
