using lab1;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        First first = new First();

        //Console.WriteLine("Введите x для подсчёта суммы последних двух цифр");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Сумма последних цифр числа {number}: {first.sumLastNums(number)}");


        //2
        //Console.WriteLine("Введите число для проверки на положительность");
        //int number = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Число {number} положительное? {first.isPositive(number)}");

        //3
        //Console.WriteLine("Введите симовл letter для проверки на заглавность");
        //string input = Console.ReadLine();
        //char letter = input[0];
        //Console.WriteLine($"Символ '{letter}' заглавный? {first.isUpperCase(letter)}");


        //4
        //Console.WriteLine("Введите число a");
        //int divisor = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите число b");
        //int diviseble = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"{divisor} делится на {diviseble} без остатка? {first.isDivisor(divisor, diviseble)}");

        //5
        //int number1, number2;

        //Console.WriteLine("Введите первое число для сложения");
        //number1 = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Введите второе число для сложения");
        //number2 = Convert.ToInt32(Console.ReadLine());
        //number1 = first.lustNumSum(number1, number2);
        //Console.WriteLine(number1);

        //Console.WriteLine("Введите третье число для сложения");
        //number2 = Convert.ToInt32(Console.ReadLine());
        //number1 = first.lustNumSum(number1, number2);
        //Console.WriteLine(number1);

        //Console.WriteLine("Введите четвертое число для сложения");
        //number2 = Convert.ToInt32(Console.ReadLine());
        //number1 = first.lustNumSum(number1, number2);
        //Console.WriteLine(number1);

        //Console.WriteLine("Введите четвертое число для сложения");
        //number2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Сумма последних цифр: {first.lustNumSum(number1, number2)}");


        //6
        //Console.WriteLine("Введите Делитель");
        //int divisor = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите Делимое");
        //int diviseble = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Результат деления: {first.safeDiv(divisor, diviseble)}");


        //7
        //Console.WriteLine("Введите первое число для сравнения");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите второе число для срванения");
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Результат сравнения: {first.makeDecision(number1, number2)}");


        //8
        //Console.WriteLine("Введите x для проверки условия что x+y=z");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите y для проверки условия что x+y=z ");
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите z для проверки условия что x+y=z");
        //int number3 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"Сумма: {first.sum3(number1, number2, number3)}");

        //9
        //Console.WriteLine("Введите число для правильной подстановки 'год', 'года' ,'лет'");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(first.age(number1));


        //10
        //Console.WriteLine("Введите день недели: ");
        //string day = Console.ReadLine();
        //first.printDays(day);

        //11
        //Console.WriteLine("Введите число ");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(first.reverseListNums(number1));

        //12
        //Console.WriteLine("Введите число для возведения в степень");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Введите степеь возведения");
        //int number2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(first.pow(number1, number2));

        //13
        //Console.WriteLine("Введите число для проверки");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(first.equalNum(number2));


        //14
        //Console.WriteLine("Введите число строк треугольника");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //first.leftTriangl(number1);

        //15
        //first.guessGame();

        //16
        //Console.WriteLine("Введите число что бы узнать есть ли число в массиве");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //int[] arr = { 1, 2, 3, 4 };
        //Console.WriteLine($"Число находится в массиве на {first.findLast(arr, number1)} месте (или его нету если -1)");


        //17
        //int[] arr = { 1, 2, 3, 4 };
        //Console.WriteLine("Введите число для добавления в массив");
        //int number1 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Введите позицию для добавления числа в массив (0-4)");
        //int position = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine($"новый массив: {first.add(arr, number1, position)}");


        //18
        //int[] arr = { 1, 2, 3, 4 };
        //first.reverse(arr);
        //Console.WriteLine(arr);


    }
}