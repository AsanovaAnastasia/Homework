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



// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{
    int sum = 0;
    if (m <= n) return sum += m + Sum(m + 1, n);
    else return sum;
}
Console.WriteLine(Sum(m, n));
