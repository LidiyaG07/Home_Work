Console.WriteLine("Введите три числа: ");
int  a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = a;


if (a > b) 
{
    max = a;
    Console.WriteLine($"Максимальное число: {max}");
}
else if (b > c) 
{
    max = b;
    Console.WriteLine($"Максимальное число: {max}");
}

