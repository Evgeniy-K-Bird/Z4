using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z4_z1_kvadrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                j = j+2 * i - 1;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, j);
            }
            Console.ReadKey();
        }
    }
}
