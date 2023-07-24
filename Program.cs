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




