/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 
*/

Console.WriteLine("Массив из трехзначных чисел: ");
int[] nums = new int[5];
GetRandom(nums);
int count = 0; 

void GetRandom(int[] nums)
{
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = new Random().Next(100, 1000);
      
    }
}
Console.WriteLine($"[{String.Join(",", nums)}]");

void GetPositive()
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[j] % 2 == 0)
        {
            count++;
        }        
    } 
   
}
 
Console.WriteLine($"Четных чисел в данном массиве: {count}");


