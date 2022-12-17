/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] 
*/

Console.WriteLine("Массив из 8 элементов: ");
int[] array = new int[8];
var random = new Random();
int result = 0;

for (int i = 1; i < array.Length; i++)
{
    array[i] = random.Next(1, 100);
    result = array[i];
}
Console.WriteLine($"[{String.Join(", ", array)}]");
