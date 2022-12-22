/* 
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Введите количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] numbers = new int[size];
Console.Write($"{size} чисел: ");
GetProgramm();

void GetProgramm()
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 1000);

        if (numbers[i] >= 0)
        count++;
    } 
       
}
Console.WriteLine(String.Join("; ", numbers));
Console.WriteLine($"Чисел больше 0 = {count}");