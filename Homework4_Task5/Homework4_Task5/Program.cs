using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int x = 5, y = 10, z = 15;
            // Перший вираз
            //x += y >> x++ * z;
            //Console.WriteLine(x);

            //// Другий вираз
            //z = ++x & y * 5;
            //Console.WriteLine(z);

            //// Третій вираз
            //y /= x + 5 | z;
            //Console.WriteLine(y);

            //// Четвертий вираз
            //z = x++ & y * 5;
            //Console.WriteLine(z);

            // П'ятий вмраз
            x = y << x++ ^ z;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
