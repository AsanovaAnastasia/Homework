// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число 1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numB = Convert.ToInt32(Console.ReadLine());

double num = Math.Pow (numA,numB);

Console.WriteLine(num);



// // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = 0;

while (num > 0)
{
    temp = num % 10;
    num = num / 10;
    sum += temp;
   
}
Console.WriteLine($"Сумма цифр введенного числа равна {sum}");


// ИЛИ

Console.WriteLine("Введите число: ");
int num =Convert.ToInt32(Console.ReadLine());

void sum(int summa)
{
    summa = 0;
    int temp = 0;

    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        summa += temp;
    }
    Console.WriteLine($"Сумма цифр введенного числа равна {summa}");
}


sum(num);





// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] nums = new int[8];
int n = nums.Length;

for (int i = 0; i < n; i++)
{
    nums[i] = new Random().Next();
    Console.Write($"{nums[i]} ");
}


// ИЛИ

void Fill(int[] numbers)
{
    int n = numbers.Length;
    int i = 0;
    while (i < n)
    {
        numbers[i] = new Random().Next();
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
int[] array = new int[8];

Fill(array);
Print(array);

