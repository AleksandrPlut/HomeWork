// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.



while (true)
{
    Console.Write("Введите число: ");
    string text = Console.ReadLine();
    if (int.TryParse(text, out int number))
    {
        Console.WriteLine("{0}", number);
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
