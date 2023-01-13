/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine("Массив 4х4:");
int m = 4;
int n = 4;
int[,] a = new int[m, n];
int count = 1;
CreateArrayP(m, n , a, count);

void CreateArrayP(int m, int n, int[,] a, int count)
{
    for (int y = 0; y < n; y++)
    {
        a[0, y] = count;
        count++;
    }
    Console.Write("   ");
    for (int x = 1; x < m; x++)
    {
        a[x, n -1] = count;
        count++;
    }
    for (int y = n -2; y >= 0; y--)
    {
        a[m -1, y] = count;
        count++;
    }
    for (int x = m -2; x > 0; x--)
    {
        a[x, 0] = count;
        count++;
    }
}

int i = 0;
int j = 0;

while (count <= m * n)
{
    a[i, j] = count;
    if (i <= j + 1 && i + j < m - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > m - 1)
        --j;
    else
        --i;
    ++count;
}


void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        Console.Write("  ");
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("  ");
            Console.Write(String.Join("   ", a[i, j]));
        }
        Console.WriteLine();
    }
}

PrintArray(a);