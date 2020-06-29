using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * «Хорошим» называется число, которое делится на сумму своих цифр.
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 */
namespace Lesson26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вывод хороших чисел от 1 до 1000000");
            List<int> goodValue = new List<int>();
            int oldTime = DateTime.Now.Millisecond;
            for(int number = 1; number <= 1_000_000; number++)
            {
                List<int> listNumber = new List<int>();
                listNumber.Clear();
                int Summa = 0;
                string strNumber = number.ToString();
                for(int i = 0; i < strNumber.Length; i++) 
                    listNumber.Add(strNumber.ElementAt(i)-48);//48 код '0' в html
                foreach(int item in listNumber) 
                    Summa +=item;
                if (Summa == number) 
                    goodValue.Add(number);
            }
            int currentTime = DateTime.Now.Millisecond;
            int diffTime = currentTime - oldTime;
            Console.WriteLine($"Прошло времени {Math.Abs(diffTime)} мс");
            Console.WriteLine($"Хорошие числа:");
            foreach(int item in goodValue)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
