using System;

namespace _5_summa_chisel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 число меньше числа 2: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            double b = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            if (a >= b)
            {
                Console.WriteLine("Ошибка!Не выполненно условие!");
            }
            else
            {
                for (double i = a; i < b; i++)
                {
                    sum = sum + i;
                }
                Console.Write("Сумма чисел между числами 1 и 2 равна: {0} ", sum);
            }
            Console.ReadKey();
        }
    }
}
