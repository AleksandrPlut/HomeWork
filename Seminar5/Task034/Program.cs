// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] arr = new Int32[10];

fillMass(arr, 100, 999);
printArray(arr);
numFind(arr);

int[] fillMass(int[] array, int from, int to)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(from, to + 1);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void numFind(int[] array)
{
    int sum = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum ++;
        }
    }
    Console.WriteLine(sum);
}
