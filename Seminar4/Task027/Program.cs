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


// Слизал с семинара, для того чтоб было, не для оценки.
// Даже смог разобраться))
/*
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int length = number.Length;
int result = 0;
for (int i = 0; i < length; i++)
{
    result = result + Convert.ToInt32(Convert.ToString(number[i]));
}
Console.WriteLine(result);
*/