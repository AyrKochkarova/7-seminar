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
 
PositionSearch(numRows, numColumns, array2D);
 
void PositionSearch(int numberRows, int numberColums, int[,] matrix)
{
 
    try
    {
        Console.WriteLine($"Элемент на позиции [{numberRows},{numberColums}] это: {matrix[numberRows - 1, numberColums - 1]}");
    }
    catch
    {
        Console.WriteLine($"Позиция [{numberRows},{numberColums}] выходит за рамки массива");
    }
 
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