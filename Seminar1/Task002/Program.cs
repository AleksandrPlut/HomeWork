// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите цело число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b){
    Console.Write("Наибольшее число A = " + a);
}
else if (b > a){
    Console.Write("Наибольшее число B = " + b);
}
else{ 
    Console.Write("Числа A и B равны = " + a);
}