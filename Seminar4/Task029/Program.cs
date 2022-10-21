// Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int  [] arr = new int [0];
void newArray(int [] arr)
{
    Console.Write("Введите длинну массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [n];
}
void newArrayP (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write("Введите элементы массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
}
//PrintArray(arr);
