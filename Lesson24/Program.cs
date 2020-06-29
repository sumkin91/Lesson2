using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */
namespace Lesson24
{
    class Program
    {
        const string login = "root";
        const string password = "GeeKBrains";
        const int check = 3;
        public static bool Check(string InputLogin, string InputPassword)
        {
            return (InputLogin == login) && (InputPassword == password);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод логина и пароля, 3 попытки");
            int inc = 0;
            do
            {
                Console.WriteLine($"Введите логин и пароль (попытка {inc+1}) через клавишу Ввода:");
                string InputLogin = Console.ReadLine();
                string InputPassword = Console.ReadLine();
                if(Check(InputLogin, InputPassword))
                {
                    break;
                }
                else
                {
                    if (inc < check - 1) Console.WriteLine("Данные не совпали, повторите ввод снова!");
                }
                inc++;
            } while (inc < check);
            if(inc < check) Console.WriteLine("Данные совпали, добро пожаловать!");
            else Console.WriteLine("Вход воспрещен!");
            Console.ReadKey();
        }
    }
}
