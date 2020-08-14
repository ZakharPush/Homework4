using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число :");
            string number = Console.ReadLine();
            int myNumber = Convert.ToInt32(number);
            if (myNumber != 0 && (myNumber & (myNumber - 1)) == 0)
                Console.WriteLine("Число є степенем 2 ");
            else Console.WriteLine("Число не є степенем 2 ");
            Console.ReadKey();
        }
    }
}
