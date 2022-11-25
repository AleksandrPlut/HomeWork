using System;

namespace DzCS_9
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Выберите задачу: \n" +
                              "1. Задача № 64; \n" +
                              "2. Задача № 66; \n" +
                              "3. Задача № 68; \n");
            
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Задача № 64. \n" +
                    "Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.");
                    printNumbers();
                    break;
                case 2:
                    Console.WriteLine("Задача № 66. \n" +
                    "Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
                    numbersSum();
                    break;
                case 3:
                    Console.WriteLine("Задача № 68. \n" +
                    "Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
                    Ackermann();
                    break;                
                default:
                    Console.WriteLine("Повторите попытку!\nВведите цифру от 1 до 3.");
                    break;
            }
        }

        private static void printNumbers()
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            void printNumbers(int n)
            {
                int number = 1;
                if (n == number)
                {
                    Console.Write(n);
                }
                else
                {
                    Console.Write($"{n}, ");
                    printNumbers(n - 1);
                }
            }
            printNumbers(number);
        }

        private static void numbersSum()
        {
            Console.WriteLine("Введите число M: ");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int numbersSum(int m, int n)
            {
                if (m > n)
                {
                    return 0;
                }
                else
                {
                    return numbersSum(m + 1, n) + m;
                }
            }
            Console.WriteLine($"Сумма чисел от M до N = {numbersSum(numberM, numberN)}");
        }

        private static void Ackermann()
        {
            Console.WriteLine("Введите число M: ");
            int numberM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число N: ");
            int numberN = Convert.ToInt32(Console.ReadLine());

            int Ackermann(int m, int n)
            {
                if (m == 0)
                {
                    return n + 1;
                }
                else if (n == 0)
                {
                    return Ackermann(m - 1, 1);
                }
                else
                {
                    return Ackermann(m - 1, Ackermann(m, n - 1));
                }
            }
            Console.WriteLine($"Функция Аккермана равна: {Ackermann(numberM, numberN)}");
        }   
    }
}
