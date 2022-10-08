// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите цело число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b){
    if (a > c){
        Console.Write("Наибольшее число: " + a);
    }
    else{
        Console.Write("Наибольшее число: " + c);
    }
}
else {
    if (b > c){
        Console.Write("Наибольшее число: " + b);
    }
    else{
        Console.Write("Наибольшее число: " + c);
    }
}