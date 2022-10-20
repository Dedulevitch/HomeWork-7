/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

Console.Clear();
Console.WriteLine("Задайте количество строк массива ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество колонок массива");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте элемент для проверки в массиве ");
int c = int.Parse(Console.ReadLine());

int result = 0;


int[,] array = new int[a, b];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 9);
        Console.Write(array[i, j]);
        Console.Write(" ");
        if (array[i, j] == c) result = c;

    }
    Console.WriteLine();

}
if (result == 0) Console.Write($"{c} => такого числа нет ");
else Console.Write($" Совпадение найдено => {result}");

