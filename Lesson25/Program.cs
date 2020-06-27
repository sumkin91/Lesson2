using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
нужно ли человеку похудеть, набрать вес или всё в норме.
б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
*/
//Возможно перебарщил с тернарной операцией
namespace Lesson25
{
    class Program
    {
        static void Main(string[] args)
        {
            int minIKM = 20;
            int maxIKM = 25;
            Console.WriteLine("Вычисление индекса массы");
            Console.WriteLine("Введите массу в кг:");
            double Weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите рост в см:");
            double Height = Convert.ToDouble(Console.ReadLine());
            double IKM = Weight / Math.Pow(Height / 100, 2);
            string message = (IKM >= minIKM) && (IKM <= maxIKM) ? "Худеть не стоит, все отлично:)" : 
                             (IKM>maxIKM)?"Жирный, жирный - поезд пассажирный:)":
                             "Чувак, ты дистрофик, набери жирка:)";
            Console.WriteLine(message);
            double diffWeight = ((IKM < minIKM) ? (minIKM - IKM): (IKM > maxIKM) ? (maxIKM - IKM) : 0) * Math.Pow(Height / 100, 2);
            Console.WriteLine("Нужно {0:0.00} кг",diffWeight);
            Console.ReadKey();
        }
    }
}
