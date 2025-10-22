using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int emin = 0;
            int emax = 0;
            Random rnd = new Random();
            Console.Write("размерность массива(n) = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-99, 100);
            }
            Console.WriteLine("исходный массив: ");
            foreach (int elem in a)
            {
                Console.Write("{0} ", elem);
            }
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[emin])
                    emin = i;
                if (a[i] > a[emax])
                    emax = i;
            }

            int temp = a[emin];
            a[emin] = a[emax];
            a[emax] = temp;

            Console.WriteLine("\nизмененный массив: ");
            foreach (int elem in a) 
            {
                Console.Write("{0} ",elem);
            }


        }
    }
}
