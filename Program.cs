// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
string Numbers(int n, int a)
{
    if (a<=n) return $"{a} " + Numbers(n, a+1);
    else return string.Empty;
}
Console.WriteLine(Numbers(n, a));


// От N до 1

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = 1;
string Numbers(int n, int a)
{
    if (a<=n) return  $"{n} " + Numbers(n-1, a);
    else return string.Empty;
}
Console.WriteLine(Numbers(n, a));