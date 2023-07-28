// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк:");
int strngs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] nums = new double[strngs, columns];


double[,] array(double[,] nums)
{

    for (int i = 0; i < strngs; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            nums[i, j] = Convert.ToDouble(Math.Round(new Random().NextDouble() * 100, 2));
        }
    }
    return nums;
}

void Print(double[,] nums)
{
    for (int i = 0; i < strngs; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(nums[i, j] + "    ");
        }
        Console.WriteLine();
    }
}
nums = array(nums);

Console.WriteLine();
Print(nums);