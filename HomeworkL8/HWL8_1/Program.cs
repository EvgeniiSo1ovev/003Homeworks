/* Задача 1: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int GetCount()
{
    return new Random().Next(2, 11);
}

int[,] GetMatrix(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int FindIndexOfMaxNumberInRow(int[,] array, int indexRow, int beginIndex)
{
    int indexOfMaxNumber = beginIndex;
    for (int i = beginIndex + 1; i < array.GetLength(1); i++)
    {
        if (array[indexRow, i] > array[indexRow, indexOfMaxNumber])
        {
            indexOfMaxNumber = i;
        }
    }
    return indexOfMaxNumber;
}

int[,] SortRowsOfMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int indexOfMaxNumber = FindIndexOfMaxNumberInRow(array, i, j);
            int MaxNumberOfRow = array[i, indexOfMaxNumber];
            array[i, indexOfMaxNumber] = array[i, j];
            array[i, j] = MaxNumberOfRow;
        }
    }
    return array;
}

int lengthOfRow = GetCount();
int lengthOfColumn = GetCount();
int[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(SortRowsOfMatrix(matrix));