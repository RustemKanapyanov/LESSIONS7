// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
/*  и возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
пример индексов этого массива:
0 1 2 3
4 5 6 7
8 9 10 11
12 13 14 15 */



Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        array[i, j] = Convert.ToInt32(new Random().Next(0, 21));
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + "\t  ");
    Console.WriteLine();
}

Console.WriteLine("Введите координаты");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());
if (c > a && d > b)
    Console.WriteLine("Такого числа нет");
else
{
    object k = array.GetValue(c, d);
    Console.WriteLine(k);
}