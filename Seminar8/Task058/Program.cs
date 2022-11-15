// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// А В
// 1 4 | 3 5
// 3 5 | 1 2

// Результирующая матрица будет:
// С
// 7 13
// 14 25

int[,] matrixA = new Int32[2, 3]; // захотелось чтоб матрицы были разные :-)
int[,] matrixB = new Int32[3, 2];
int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

FillArray(matrixA, 1, 10);
FillArray(matrixB, 1, 10);
PrintArray(matrixA);
Console.WriteLine(" "); 
PrintArray(matrixB);
Console.WriteLine(" ");

PrintArray(matrixMultiplication(matrixA, matrixB));

    int[,] matrixMultiplication(int[,] matrixA, int[,] matrixB)
    {       
        if (matrixA.GetLength(1) != matrixB.GetLength(0))
        {
            throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
        }

        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                matrixC[i, j] = 0;

                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return matrixC;
    }

void FillArray(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }

        Console.WriteLine(" ");
    }
}