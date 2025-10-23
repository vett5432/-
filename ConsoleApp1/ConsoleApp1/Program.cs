using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            if (x == 0 || x < -1)
            {
                Console.WriteLine("Функция не определена");
            }
            else
            {
                double y = Math.Log10(x - 1);
                Console.Write("y= {0:f2}", y);
            }
        }
    }
}
