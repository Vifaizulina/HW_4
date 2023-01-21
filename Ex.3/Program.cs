// Напишите программу, которая задаёт массив из 8 элементов, которые вводит пользователь,
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[Вывод массива: {string.Join(" ,",array)}]"); 

