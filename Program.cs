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






// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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


Console.WriteLine("Введите номер строчки: ");
int strPos = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбика: ");
int colPos = Convert.ToInt32(Console.ReadLine());


void FindNum(int[,] nums)
{
    if (strPos<0 || strPos > nums.GetLength(0)){
        Console.WriteLine("Такой строчки нет");
    }
    else if (colPos< 0 || colPos > nums.GetLength(1))
    {
        Console.WriteLine("Такого столбика нет.");
    }
    else { Console.WriteLine($"{nums[strPos - 1, colPos - 1]} - это {strPos} элемент в {colPos} столбике"); }
}



Console.WriteLine();
FindNum(nums);




// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Arifm(int[,] nums, double temp)
{
    for (int j = 0; j < nums.GetLength(1); j++)
    {
        temp = 0;
        for (int i = 0; i < nums.GetLength(0); i++)

        {
            temp += nums[i, j];
        }
        temp = Math.Round(temp/strgs,2);
        Console.Write(temp + "            ");

    }

}


Fill(nums);
Print(nums);

Console.WriteLine();
Arifm(nums, 1);




