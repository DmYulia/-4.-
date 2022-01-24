using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_Введите целое число больше нуля..");
            double n;

            //ввод данных
            int i = 0;
            do
            {
                n = Convert.ToDouble(Console.ReadLine());

                if ((n <= 0) | ((n % 1) != 0))
                {
                    Console.WriteLine("_Ошибка ввода данных! Попробуйте еще раз..");
                }
                else
                    i++;
            }
            while (i == 0);

            //приведение к int
            int N = (int)n;
            int N2 = 0;

            //вычисление квадрата N
            i = 1;
            int j = 1;
            do
            {
                N2 += i;
                Console.WriteLine($"_{j}^2 = {N2}");
                j++;
                i += 2;

            }
            while (i <= (2 * N - 1));

            Console.ReadKey();
        }
    }
}
