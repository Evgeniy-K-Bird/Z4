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
            Console.WriteLine("Введите число стороны A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число стороны B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c > a || c > b)
            {
                Console.WriteLine("В данном прямоугольке не возможно разместить квадрат с размером С");
            }
            else
            {
                int itog = 0;
                int na = 0;
                int nb = 0;
                while (c <= b)
                {
                    nb++;
                    b -= c;
                }
                while (c <= a)
                {
                    a -= c;
                    na++;
                }
                int x = 0;
                if (na==1||nb==1)
                {
                    itog = (na > nb)? na : nb;
                }
                else
                    itog = (na > nb) ? na : nb;
                while (x!=na)
                {
                    itog++;
                    x++;
                }
                Console.WriteLine("Всего квадратов {0}", itog);
            }
            Console.ReadLine();
        }
    }
}
