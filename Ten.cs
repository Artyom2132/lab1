using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Ten
    {
        public void printDays(string x)
        {
            switch (x)
            {
                case "Понедельник":
                    Console.WriteLine("Вторник");
                    Console.WriteLine("Среда");
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;

                case "Вторник":
                    Console.WriteLine("Среда");
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;

                case "Среда":
                    Console.WriteLine("Четверг");
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;

                case "Четверг":
                    Console.WriteLine("Пятница");
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;

                case "Пятница":
                    Console.WriteLine("Суббота");
                    Console.WriteLine("Воскресенье");
                    break;

                case "Суббота":
                    Console.WriteLine("Воскресенье");
                    break;

                case "Воскресенье":
                    break;

                default:
                    Console.WriteLine("Это не день недели");
                    break;
            }
        }
    }
}
