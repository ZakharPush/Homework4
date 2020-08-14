using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть число :");
            string number = Console.ReadLine();
            int myNumber = Convert.ToInt32(number);
            if ((myNumber & 1) == 0)
                Console.WriteLine("Число є парним ");
            else Console.WriteLine("Число  є не парним ");
            Console.WriteLine();

            //Другий варіант перевірки на парність
            Console.WriteLine("Введіть число :");
            string number2 = Console.ReadLine();
            int myNumber2 = Convert.ToInt32(number2);
            if (myNumber2 << 31 == 0) Console.WriteLine("Число є парним ");
            else Console.WriteLine("Число  є не парним ");
            Console.ReadKey();
        }
    }
}
