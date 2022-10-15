// Задача 13: Напишите программу, которая выводит третью (слева) цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("Введите любое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
 while (n > 1000)
{
    n = n/10;
}

while (n < 100)
{
    Console.WriteLine("В введенном числе нет третьей цифры, давай еще разок: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(n % 10);
*/

// Решение задачи через строки

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string number_text = Convert.ToString(number);
if (number_text.Length > 2){
    Console.WriteLine("Третья цифра = " + number_text[2]);
}
else{
    Console.WriteLine("Третьей цифры нет");
}

