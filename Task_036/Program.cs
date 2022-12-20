/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
// Ошибка в примере. Пример идет на четных позиций. А условие задачи на нечетные позиции.

Console.WriteLine("Введите длину маасива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;
Console.WriteLine($"Массив из {size} элементов: ");
GetRandom(array);



void GetRandom(int[] array)
{
    for (int i = 0; i < array.Length; i+=2)
    {
        array[i] = new Random().Next(-6, 20);
        sum = sum + array[i];
        
       
    }
}
Console.WriteLine($"[{String.Join(",", array)}] ");
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {sum}");

