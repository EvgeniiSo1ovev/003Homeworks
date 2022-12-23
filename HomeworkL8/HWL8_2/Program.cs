/* Задача 2: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

int SumNumbersInRow(int[,] array, int indexRow)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum += array[indexRow, i];
    }
    return sum;
}

int FindIndexRowOfMinValueOfRowSums(int[,] array)
{
    int indexRowOfMinValueOfRowSums = 0;
    int minValueOfRowSums = SumNumbersInRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sumNumbersInRow = SumNumbersInRow(array, i);
        if (sumNumbersInRow < minValueOfRowSums)
        {
            indexRowOfMinValueOfRowSums = i;
            minValueOfRowSums = sumNumbersInRow;
        }
    }
    return indexRowOfMinValueOfRowSums;
}

int lengthOfRow = GetCount();
int lengthOfColumn = GetCount();
int[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn);
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindIndexRowOfMinValueOfRowSums(matrix) + 1} строка");