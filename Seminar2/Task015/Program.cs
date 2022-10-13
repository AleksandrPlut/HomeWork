// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели(от 1 до7): ");
int weekDay=Convert.ToInt32(Console.ReadLine());
while (weekDay<1|weekDay>7){
    Console.WriteLine("Число не соответствует ни одному из дней недели");
    weekDay=Convert.ToInt32(Console.ReadLine());
}
if (weekDay >= 1 & weekDay <= 4){
    Console.WriteLine("У меня для тебя плохие новости, завтра на работу.");
}
if (weekDay == 5){
    Console.WriteLine("Пятница. Еще не выходной, но уже совсем близко");
}

if (weekDay == 6 | weekDay == 7){
    Console.WriteLine("Выходной, сегодня можно выспаться, при условии конечно, что у тебя нет вредных маленьких детей))");
}
