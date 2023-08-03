// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine("Введите количество строк:");
int strgs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] nums = new int[strgs, columns];

void Fill(int[,] nums)
{

    for (int i = 0; i < strgs; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            nums[i, j] = Convert.ToInt32(new Random().Next(100));
        }
    }
}

void Print(int[,] nums)
{
    for (int i = 0; i < strgs; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(nums[i, j] + "    ");
        }
        Console.WriteLine();
    }
}
Fill(nums);
Print(nums);
Console.WriteLine();

void SortArray(int[,] nums)
{

    for (int i = 0; i < strgs; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < columns - 1; k++)
            {
                if (nums[i, k] < nums[i, k + 1])
                {
                    int temp = nums[i, k + 1];
                    nums[i, k + 1] = nums[i, k];
                    nums[i, k] = temp;
                }
            }
        }
    }
}
SortArray(nums);
Print(nums);