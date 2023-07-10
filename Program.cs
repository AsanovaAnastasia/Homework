// // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// Console.WriteLine("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int x = num/10;
// num = x%10;

// Console.WriteLine($"{num} - вторая цифра введенного числа");


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














