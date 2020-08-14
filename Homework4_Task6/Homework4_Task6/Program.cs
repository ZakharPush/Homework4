using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть кількість років : " );
            string year = Console.ReadLine();
            double myYear = Convert.ToDouble(year);
            Console.WriteLine("Введіть заробітню плату : ");
            string salary = Console.ReadLine();
            double mySalary = Convert.ToDouble(salary);
            if (myYear < 5) Console.WriteLine(" Премія : {0}",mySalary * 0.1);
            else if (myYear >= 5 && myYear < 10) Console.WriteLine("Премія : {0}", mySalary * 0.15);
            else if (myYear >= 10 && myYear < 15) Console.WriteLine("Премія :{0} ", mySalary * 0.25);
            else if (myYear >= 15 && myYear < 20) Console.WriteLine("Премія : {0}", mySalary * 0.35);
            else if (myYear >= 20 && myYear < 25) Console.WriteLine("Премія : {0}", mySalary * 0.45);
            else if (myYear >= 25) Console.WriteLine("Премія : {0}", mySalary * 0.5);
            Console.ReadKey();
        }
    }
}
