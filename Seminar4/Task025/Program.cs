// Задача 25. Напишите цикл, который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.

Console.Write("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b == 0)
{
   Console.WriteLine("Число А в степени В = " + 1);
}
else if (b < 0)
{
    Console.WriteLine("Результат получается меньше 1, оно нам надо?");
}
else 
{
    int newA = a;
    int count = 0;
    while (count < b-1)
    {
    newA = newA * a;
    count ++;
    }
    Console.WriteLine("Число А в степени В = " + newA);
}

