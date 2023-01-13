/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Двумерный массив:");
int[,] a = new int[4, 4];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = new Random().Next(1, 10);
    }
}

for (int i = 0; i < a.GetLength(0); i++)
{
    Console.Write(" ");
    for (int j = 0; j < a.GetLength(1); j++)
    {
        Console.Write(" " + a[i, j]);
    }
    Console.WriteLine();
}

void MinNumberArray(int[,] a)
{
    int minN = 0;
    int array = 0;
    int line = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        minN += a[0, i];
    }
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++) array += a[i, j];
        {
            if (array < minN)
            {
                minN = array;
                line = i;
            }
        }
        array = 0;
    }
    Console.WriteLine($"Минимальное число в {line + 1} строке");
}

Console.WriteLine();
MinNumberArray(a);