using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int o = 0;
            int n;
            do
            {
                Console.WriteLine("Введите число, или введите 0 для завершения ввода ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                }
                else
                if (n > 0)
                {
                    p++;
                }
                else
                {
                    o++;
                }
            } while (n != 0);
            if (p == o)
            {
                Console.WriteLine("Одинаковое число положительных ({0}шт.) и отрицательных числел({1}шт.).", p, o);
            }
            else
            {
                int itog = (p < o) ? o : p;
                string text = (p < o) ? "отрицательных" : "положительных";
                Console.WriteLine("Больше всего {0} чисел, {1}шт.", text, itog);
            }
            Console.ReadLine();
        }
    }
}
