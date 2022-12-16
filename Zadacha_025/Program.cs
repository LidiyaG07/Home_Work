/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


Console.WriteLine("Введите число первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число второе число");
int b = Convert.ToInt32(Console.ReadLine());
GetSumm(a, b);

void GetSumm(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
        {
            result = result *a;
                
        }
        Console.WriteLine(result);
}

