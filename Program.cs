
Семинар 2

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int x = num/10;
num = x%10;

Console.WriteLine($"{num} - вторая цифра введенного числа");


// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("Понедельник не является выходным");
}
else if (num == 2)
{
    Console.WriteLine("Вторник не является выходным");
}
else if (num == 3)
{
    Console.WriteLine("Среда не является выходным");
}
else if (num == 4)
{
    Console.WriteLine("Четверг не является выходным");
}
else if (num == 5)
{
    Console.WriteLine("Пятница не является выходным, но он уже близко:)");
}
else if (num == 6)
{
    Console.WriteLine("Суббота! Ураа! Выходной!");
}
else if (num == 7)
{
    Console.WriteLine("Воскресенье! Ураа! Выходной!");
}
else
{
    Console.WriteLine("Такого дня недели нет");
}












Семинар 3


﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.Clear();
Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

Console.WriteLine($"{Math.Round(result,3)}");




// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
int n = num.Length;

for (int i = 0; i <= n / 2; i++)
{
    if (num[i] == num[n - i - 1])
    {
        Console.WriteLine($"Число {num} является палиндромом.");    
    }
    else
        Console.WriteLine($"Число {num} не является палиндромом.");
        break;
 
}




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write($"{Math.Pow(i,3)} ");
}
