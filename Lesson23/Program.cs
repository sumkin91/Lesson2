using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
namespace Lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Number = new List<string>();
            Console.WriteLine("Введите массив (при окончании ввода наберите '0')");
            do
            {
                Number.Add(Console.ReadLine());
            } while (Number.ElementAt(Number.Count-1) != "0");
            int Sum = 0;
            foreach(string Item in Number)
            {
                int Value = Convert.ToInt32(Item);
                if (Value % 2 != 0)
                {
                    Sum += Value;
                }
            }
            Console.WriteLine($"Сумма нечетных значений равна: {Sum}");
            Console.ReadKey();
        }
    }
}
