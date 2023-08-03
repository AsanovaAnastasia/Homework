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


// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            nums[i, j] = Convert.ToInt32(new Random().Next(10));
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

void Arifm(int[,] nums)
{
    int temp = int.MaxValue;
    int str = 0;
    for (int i = 0; i < nums.GetLength(0); i++)
    {

        int sum = 0;
        for (int j = 0; j < nums.GetLength(1); j++)
        {

            sum += nums[i, j];

        }
        Console.Write(sum + " ");
        Console.WriteLine();
        if (temp > sum)
            temp = sum;
            str = i+1;
    }
    Console.Write($"{str} строка с минимальной суммой {temp}.");
}

Arifm(nums);


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int str1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков первой матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк второй матрицы: ");
int str2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбиков второй матрицы: ");
int col2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix1 = new int[str1, col1];
int[,] matrix2 = new int[str2, col2];
int[,] result = new int[str1, col2];

void Fill(int[,] nums)
{

    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
           nums[i, j] = Convert.ToInt32(new Random().Next(10));
        }
    }
}

void Print(int[,] nums)
{
    for (int i = 0; i < nums.GetLength(0); i++)
    {
        for (int j = 0; j < nums.GetLength(1); j++)
        {
            Console.Write(nums[i, j] + "    ");
        }
        Console.WriteLine();
    }
}
Fill(matrix1);
Print(matrix1);
Console.WriteLine();
Fill(matrix2);
Print(matrix2);
Console.WriteLine();


void Product(int[,] matrix1, int[,] matrix2, int[,] result)
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += (matrix1[i, k] * matrix2[k, j]);
            }
            result[i, j] = sum;
        }
    }
}
Product(matrix1,matrix2,result);
Print(result);