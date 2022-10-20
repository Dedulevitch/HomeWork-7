/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */
Console.Clear();
Console.WriteLine("Задайте количество строк массива ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте количество колонок массива");
int b = int.Parse(Console.ReadLine());

int[,] array = new int[a, b];
for (int i = 0; i < array.GetLength(0); i++)
{
    double sum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 9);
        Console.Write(array[i, j]);
        Console.Write(" ");
    }
   
    Console.WriteLine();

}

for (int i = 0; i < array.GetLength(1); i++)
{
    double sum = 0; 

    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum+= array[j,i];
    }
    Console.Write($"Результат {Math.Round(sum/array.GetLength(0),1)}" + ";"); 
    
    Console.WriteLine(" ");

}





