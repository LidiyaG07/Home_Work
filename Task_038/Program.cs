/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 
*/

Console.WriteLine("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] nums = new double[size];
double sum = 0;
double numMin = 0;
double numMax = 0;
Console.WriteLine($"Массив из {size} элементов: ");
GetProgramm(); //   (nums, sum, numMin, numMax); и здесь, тоже добавляю перечисление переменных, то см. стр.15 

void GetProgramm() // (double[] nums, double sum, double numMin, double numMax) 
//Подскажите, почему когда я оставляю здесь в скобках перечесление переменных, мне выдет ошиьку "Index was outside the bounds of the array."?????
// И "0" это самое маленькое число среди вещественных???
// В задаче №34 при тех же условиях с написанием переменных у меня вообще не считает сумму.
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().NextDouble();
        while (nums[i] > numMax)
        {
            numMax = nums[i];
            i++;

            if (nums[i] < numMin)
            {
                numMin = nums[i];
                i++;
            }
        }
        
    }
    sum = sum + numMin + numMax;
}
Console.WriteLine($"[{String.Join("; ", nums)}]");
Console.WriteLine($"Минимальный элемент в массиве: {numMin}");
Console.WriteLine($"Максимальный элемент в массиве: {numMax}");
Console.WriteLine($"Сумма максимального и минимального элемента в массиве: {sum}");