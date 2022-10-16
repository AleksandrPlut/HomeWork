// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n <= 9999 || n > 99999)
{
    Console.Write("Вы ввели непятизначное число, попробуйте еще раз: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int first_digit = n/10000;
int second_digit = n/1000%10;
int fourth_digit = n/10%10;
int fifth_digit = n%10;
if (first_digit == fifth_digit && second_digit==fourth_digit)
{
    Console.Write("Число является палиндромомо");
}
else 
{
    Console.Write("Число не является палиндромомо");
}
 
