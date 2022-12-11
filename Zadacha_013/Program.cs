Console.WriteLine("Введите трезначное число: ");
string numbers = Console.ReadLine();
int num = Convert.ToInt32(numbers);

if (num <99 )
{
    Console.Write("Третьей цифры нет");
} else
{
    Console.Write(num.ToString()[2]);
}