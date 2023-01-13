/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.WriteLine("Дано две матрициы:");
int[,] a1 = new int[2, 2];
int[,] a2 = new int[2, 2];
int[,] result = new int[2, 2];
int summ = 0;

RandomArray(a1, a2);
PrintArray(a1, a2);
ResultArray(a1, a2, result, summ);
PrintResultArray(result);


void RandomArray(int[,] a1, int[,] a2)
{
    for (int i = 0; i < a1.GetLength(0) && i < a2.GetLength(0); i++)
    {
        for (int j = 0; j < a1.GetLength(1) && j < a2.GetLength(1); j++)
        {
            a1[i, j] = new Random().Next(1, 10);
            a2[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] a1, int[,] a2)
{
    for (int i = 0; i < a1.GetLength(0) && i < a2.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < a2.GetLength(1) && j < a2.GetLength(1); j++)
        {
            Console.Write(String.Join(" ", a1[i, j], a2[i, j]));
            Console.Write(" | ");
        }
        Console.WriteLine();
    }
}

void ResultArray(int[,] a1, int[,] a2, int[,] result, int summ)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < a1.GetLength(1); k++)
            {
                summ += a1[i, k] * a2[k, j];
            }
            result[i, j] = summ;
        }
    }
}

void PrintResultArray(int[,] result)
{
    Console.WriteLine("Произведение двух матриц: ");
    for (int i = 0; i < result.GetLength(0); i++)
    {
        Console.Write("  ");
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write("  ");
            Console.Write(String.Join(" ", result[i, j]));
            
        }
        Console.WriteLine();
    }
}