// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();

Console.Write("Введите число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число Б:");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0) 
    Console.WriteLine(Math.Pow(a,b));
