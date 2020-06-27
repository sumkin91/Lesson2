using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.
*/
namespace Lesson27
{
    class Program
    {
        
        static public void enterNumber(int first, int second)
        {
            if (first <= second)
            {
                Console.Write($"{first} ");
                enterNumber(first + 1, second);
            }
            else return;
        }

        static public int summaNumber(int first, int second)
        {
            if (first <= second)
            {
                return summaNumber(first+1,second)+first;
            }
            else return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целочисленных числа через клавишу Ввода (первое число должно быть больше второго):");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Вывод последовательности чисел в диапазоне от {first} до {second}: "); enterNumber(first, second);
            Console.WriteLine($"\nВывод суммы чисел в диапазоне от {first} до {second}: {summaNumber(first,second)}");
            Console.ReadKey();
        }
    }
}
