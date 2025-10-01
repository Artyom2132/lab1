using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class First
    {
        public int sumLastNums(int x)
        {
            if (x % 10 > 1) return ((x / 10) % 10) + (x % 10);
            {
                return ((x / 10)%10) + (x % 10);
            }
        }
        public bool isPositive(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }
        public bool isDivisor(int a, int b)
        {
            if ((a % b == 0) || (b % a == 0))
            {
                return true;
            }
            return false;
        }
        public int lustNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }
        public String makeDecision(int a, int b)
        {
            if (a > b)
            {
                return "a > b";
            }
            else if (a < b)
            {
                return "a < b";
            }
            else
            {
                return "a == b";
            }
        }
        public bool sum3(int x, int y, int z)
        {
            if (x + y == z)
            {
                return true;
            }
            return false;
        }
        public String age(int x)
        {
            if ((x % 10 == 1) && (x != 11))
            {
                return $"{x} год";
            }
            else if ((2 <= x % 10 && x % 10 <= 4) && (x != 11) && (x != 12) && (x != 13) && (x != 14))
            {
                return $"{x} года";
            }
            else
            {
                return $"{x} лет";
            }
        }
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
        public String reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0; i--)
            {
                result += i + " ";
            }
            return result;
        }
        public int pow(int x, int y)
        {
            int c = x * 1;
            for (int i = 1; i != y; i++)
            {
                c *= x;
            }
            return c;
        }
        public bool equalNum(int x)
        {
            int firstDigit = x % 10;
            x = x / 10;

            while (x > 0)
            {
                int currentDigit = x % 10;
                if (currentDigit != firstDigit)
                    return false;
                x = x / 10;
            }

            return true;
        }
        public void leftTriangl(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                string str = new string('*', i);
                Console.WriteLine(str);
            }
        }
        public void guessGame()
        {

            int guessedNum = Random.Shared.Next(0, 9);
            int i = 1;

            while (true)
            {
                Console.WriteLine("Угадайте загадонное число от 0 до 9");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number == guessedNum)
                {
                    Console.WriteLine($"Вы угадили за {i} попыток");
                    break;
                }
                else if (number != guessedNum)
                {
                    Console.WriteLine("Не угадали попробуйте еще");
                }
                i += 1;
            }

        }
        public int findLast(int[] arr, int x)
        {
            int equalent = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    equalent = i;
                }
            }
            return equalent;
        }
        public int[] add(int[] arr, int x, int pos)
        {
            int[] newArr = new int[arr.Length + 1];
            for (int i = 0, j = 0; i < newArr.Length; i++, j++)
            {
                if (i == pos)
                {
                    newArr[i] = x;
                    j--;
                }
                else
                {
                    newArr[i] = arr[j];
                }
            }
            return newArr;
        }
    }
}
