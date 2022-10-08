// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите четное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
while(n % 2 != 0){
    Console.WriteLine("Попробуй еще раз, мой хороший: ");
    n = Convert.ToInt32(Console.ReadLine());
    i ++;
    if (i > 2){            //easter egg
        Console.WriteLine("Я тебе щас учебником математики за 3 класс по голове настучу!!!"); 
        i = 0;
    }    
}
Console.WriteLine("Верно, " + n + " четное число.");

