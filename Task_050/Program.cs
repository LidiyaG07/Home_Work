/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите позию в строке: ");
int positionX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позию в столбце: ");
int positionY = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
Console.WriteLine("Двумерный массив:");
GetProgram(array);
PrintArray(array);
FindNumber(positionX, positionY, array);

void GetProgram(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}

void FindNumber(int positionX, int positionY, int[,] array)
{
    if ((positionX < 0 && positionX > array.GetLength(0)) && (positionY < 0 && positionY > array.GetLength(1)))
    {
        Console.WriteLine("Такого числа в массиве нет!");
    }
    else
    {
        Console.WriteLine($"Число в масиве: {array[positionX, positionY]}");
    }
}