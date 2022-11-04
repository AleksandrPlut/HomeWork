// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] CreatArray(int length)
{
    double [] answer = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(1, 1000);
        answer[i] = answer[i] / 10; // перевод чисел к десятичным значениям
    }
    return answer;
}
 
double MaxMinDifferenceElements(double[] a)
{
    double max = a[0];
    double min = a[0];
    for (int i = 1; i < a.Length; i++)
    {
        if (a[i] > max)
        {
            max = a[i];
        }
         if (a[i] < min)
        {
            min = a[i];
        }
    }
    return max-min;
}
 
void printArray(double[] answer)
{
    int count = 0;
    while (count < answer.Length)
    {
        System.Console.Write($"{answer[count]}\t");
        count++;
    }
    System.Console.WriteLine();
}
 
double[] array1 = CreatArray(10);
printArray(array1);
System.Console.WriteLine(); 
System.Console.WriteLine(MaxMinDifferenceElements(array1));
 



