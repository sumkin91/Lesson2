using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать метод, возвращающий минимальное из трёх чисел*/
namespace Lesson21
{
    class Program
    {
        public static int MinNumber(List<int> Number)
        {
            Number.Sort();
            return Number.ElementAt(0);
        }

        static void Main(string[] args)
        {
            int i = 0;
            string[] ListString = new string[3];
            Console.WriteLine("Поиск минимального числа из трех");
            Console.WriteLine("Введите 3 натуральных числа через кнопку ввода:");
            
            do
            {
                ListString[i] = Console.ReadLine();
                i++;
            } while (i < 3);

            List<int> Number = new List<int>();
            for (int j = 0; j<ListString.Length;j++){
                Number.Add(Convert.ToInt32(ListString.ElementAt(j)));
            }
            Console.WriteLine($"Минимальное число из массива: {MinNumber(Number)}");
            Console.ReadKey();
        }
    }
}
