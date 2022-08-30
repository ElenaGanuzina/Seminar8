// 55. Задать двумерный массив. Поменять строки на столбцы.
// Если невозможно, вывести сообщение для пользователя.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int column = 0; column < arr.GetLength(1); column++)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

int[,] TransposeMatrix(int[,] matrix)
{
    int rowCount = matrix.GetLength(1);
    int columnCount = matrix.GetLength(0);
    int[,] newMartix = new int[rowCount,columnCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            newMartix[i,j] = matrix[j, i];
        }
    }
    return newMartix;
}

int[,] matrix = CreateMatrix(3, 4, 0, 50);
PrintMatrix(matrix);
Console.WriteLine();
int[,]newMatrix = TransposeMatrix(matrix);
PrintMatrix(newMatrix);
