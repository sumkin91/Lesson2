using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать метод подсчета количества цифр числа.
namespace Lesson22
{
    class Program
    {
        public static int Number(string StringNumber)
        {
            return StringNumber.Count(); ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Подсчет числа цифр в числе");
            Console.WriteLine("Введите число:");
            string StringNumber = Console.ReadLine();
            Console.WriteLine($"Количество цифр числа {StringNumber}: {Number(StringNumber)}"); 
            Console.ReadKey();
        }
    }
}
