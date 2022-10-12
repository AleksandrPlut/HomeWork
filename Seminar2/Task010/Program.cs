// Задача 10: Написать программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
         while (number < 99 | number > 1000)
         {
            Console.Write("Вы ввели не трехзначное число, попробуйте еще раз: ");
            number = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("Вторая цифра числа: " + Convert.ToInt32((number / 10) % 10));
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

/*
    // Второй вариант, но у меня так и не получилось довести его до ума((((
    // Хотелось сделать чтоб после прерывания программа закрывалась, но
    // она все равно выводит остаток неправильного числа (нетрехзначного)
    // помогите а... ;-)

Console.Write("Введите трёхзначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (n < 99 | n > 1000)
{
    Console.Write("Три цифры должно быть в числе, ТРИ, понимаешь? Пробуй еще: ");
    n = Convert.ToInt32(Console.ReadLine());
    i ++;
    if (i => 2)
    {
        Console.Write("Введите Ваше имя: ");
        string username = Console.ReadLine();
        Console.Write("Я еще ни разу не встречал таких талантливых людей как ты, ");
        Console.Write(username);
        Console.Write(", у тебя все получится, просто больше не трогай мой код!!! ");
        break;
    }   
}
    Console.Write("Вторая цифра числа: " + Convert.ToInt32((n / 10) % 10));
*/
