// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число 1: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numB = Convert.ToInt32(Console.ReadLine());

double num = Math.Pow (numA,numB);

Console.WriteLine(num);