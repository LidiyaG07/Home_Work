/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);

if (number >= 6 && number <= 7)
{
    Console.Write("Да");
    
}
else if (number <6)
{
    Console.Write("Нет");
}
else
{
    Console.WriteLine("В недели только 7 дней!");
}
