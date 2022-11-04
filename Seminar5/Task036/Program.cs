// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to+1);
    }
}

int SumElements(int[] a)
{
    int Sum = 0;
    for (int i = 1; i < a.Length; i = i + 2)
    {
        Sum = Sum + a[i];
    }
    return Sum;
}

void PrintArray(int[] array)
{
    int count = 0;
    while (count < array.Length)
    {
        System.Console.Write($"{array[count]} ");
        count++;
    }
    System.Console.WriteLine();
}

int[] arr = new Int32[10];
FillArray(arr, -10, 100);
PrintArray(arr);
Console.WriteLine(SumElements(arr));

