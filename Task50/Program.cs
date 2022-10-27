// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


Console.WriteLine("Введите номер строки:");
int numRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
int numColumns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 300);
PrintMatrix(array2D);

int foundPosition = PositionSearch(numRows, numColumns, array2D);
Console.WriteLine($"Значение элемента в заданной позиции = {foundPosition}");


int PositionSearch(int numberRows, int numberColums, int[,] matrix)
{

    int position = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == numberRows)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == numberColums)
                {
                    position = matrix[i, j];
                    break;
                }

            }
        }
        // else position = 0;
    }


    return position;

}


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

