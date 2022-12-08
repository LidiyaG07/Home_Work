Console.Write("Введите целое число: ");
int a;
a = Convert.ToInt32(Console.ReadLine());

if (a%2==1)
{
    Console.WriteLine($"Число {a} нечетное!");
}
else 
{
    Console.WriteLine($"Число {a} четное!");
}
