// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] FillArray(int nums)
{
    Console.WriteLine("Введите количество элементов массива: ");
    nums = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[nums];

    for (int i = 0; i < nums; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Print(int[] nums)
{
    int n = nums.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write(nums[i] + " ");
        i++;
    }
    Console.WriteLine();
}

void Check(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > 0)
        {
            sum += 1;
        }

    }
    Console.WriteLine($"В заданном массиве количество чисел, которые > 0 равно {sum}");
}

int[] nums = FillArray(1);
Print(nums);
Check(nums);




// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2:  ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые являются параллельными");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаютя в {x} и {y}");
}



