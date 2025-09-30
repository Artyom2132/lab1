using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Fifthteen
    {
        public void guessGame()
        {

            int guessedNum = Random.Shared.Next(0, 9);
            int i = 1;

            while (true)
            {
                Console.WriteLine("Угадайте загадонное число от 0 до 9");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == guessedNum)
                { 
                    Console.WriteLine($"Вы угадили за {i} попыток");
                    break;
                }
                else if (x != guessedNum)
                {
                    Console.WriteLine("Не угадали попробуйте еще");
                }
                i += 1;
            }

        }
    }
}
