/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
Console.Clear();
Console.WriteLine("Задайте количество строк массива ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество колонок массива");
int b = int.Parse(Console.ReadLine());
int [,] array = new int [a,b];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-9, 9); 
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

