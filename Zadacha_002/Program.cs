Console.WriteLine("Введите два числа:");
int a, b;
Console.WriteLine("Введите первое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = Convert.ToInt32(Console.ReadLine());

bool int_1 = a > b;
bool int_2 = a == b;
bool int_3 = a < b;

if (int_1)
{
    Console.WriteLine($"Число {a} больше, чем {b}");
}
else if (int_2)
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
else 
{
    Console.WriteLine($"Число {b} больше, чем {a}");
}

