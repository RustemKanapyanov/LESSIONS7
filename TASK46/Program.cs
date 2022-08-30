// Задача 46: Задайте двумерный массив размером m×n, 
/* заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());// Количество строк

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine()); // Количество столбцов

int[,] ourMatrix = GetMatrix(m, n, -10, 10);
PrntMatrix(ourMatrix);

int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}