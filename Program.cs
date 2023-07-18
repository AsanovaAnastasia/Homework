// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[15];

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next(100, 1000);
        i++;
    }
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
}

void sum()
{
    int n = array.Length;
    int i = 0;
    int summa = 0;
    while (i < n)
    {
        if (array[i] % 2 == 0)
        {
            summa += 1;
        }
        i++;
    }
    Console.WriteLine($"Количество четный чисел во введенном числе : {summa}");
}

Fill(array);
Print(array);
Console.WriteLine();
sum();


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next(50);
        i++;
    }
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
}

void sum()
{
    int n = array.Length;
    int i = 0;
    int summa = 0;
    while (i < n)
    {
        summa += array[i];
        i = i + 2;
    }
    Console.WriteLine($"Сумма чисел стоящих на нечетных позициях : {summa}");
}

Fill(array);
Print(array);
Console.WriteLine();
sum();




// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[10];

void Fill(double[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = Math.Round(new Random().NextDouble() * 100, 2);
        i++;
    }

}
void Print(double[] nums)
{
    int n = nums.Length;
    int i = 0;
    while (i < n)
    {
        Console.Write(nums[i] + "   ");
        i++;
    }
}

void MinMax()
{
    int i = 0;
    int n = array.Length;
    double min = array[0];
    double max = array[0];

    while (i<n){
        if (array[i]> max){
            max = array[i];
        }
        else if (array[i]< min){
            min = array[i];
        }
        i++;
    }
    Console.WriteLine($"Минимальное вещественное число массива: {min}");
    Console.WriteLine($"Максимальное вещественное число массива: {max}");
}


Fill(array);
Print(array);
Console.WriteLine();
MinMax();
