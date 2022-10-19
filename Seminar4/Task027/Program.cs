// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (n > 0)
{
    result = result + n % 10;
    n = n / 10;
 }
Console.WriteLine(result);

