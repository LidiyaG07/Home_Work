/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

// Задаем массив
 Console.WriteLine("Двумерный массив:");
int[,] array = new int[3, 4];
int[] summ = new int[array.GetLength(1)];

// Задаем численность в массиве
Random rnd = new();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
    }
}

// Вывод массива
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write(" ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(String.Format("{0,5:0.##}", array[i, j]));
    }
    Console.WriteLine();
}

// Получение среднеарифмитического
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summ[j] += array[i, j];
    }
}

// Вывод среднеарифмитического
for (int i = 0; i < summ.Length; i++)
{
    Console.WriteLine(String.Format("среднеарифмитическое значение: " + "{0,5:0.##}", (double)summ[i] / array.GetLength(0)));
}