/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int len = NumberLen(number);
SummNumbers(number, len);

int NumberLen(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}

void SummNumbers(int b, int len)
{
    int result = 0;
    for (int i = 1; i <= len; i++)
    {
        result += b % 10;
        b /= 10;
    }
    Console.WriteLine(result);
}
