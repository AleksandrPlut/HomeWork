// Задача 29. Задача 29: Напишите программу, которая задаёт массив произвольной длины, 
// заполняет произвольными элементами и выводит их на экран.
// Длину массива и элементы массива можно задать рандомно или попросить пользователя ввести в консоли.

Console.WriteLine("Введите количество элементов массива");
int n = Convert.ToInt32(Console.ReadLine());

void newArray(int[] array) 
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array [index] = new Random(). Next(1,100);
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position] + " ");
        position ++;
    }
}