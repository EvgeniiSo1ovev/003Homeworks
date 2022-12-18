/* Задача 3. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double ArithmeticMeanColumn(int[,] array, int iColumn)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, iColumn];
    }
    return sum / array.GetLength(0);
}

string GetAllColumnsArifMean(int[,] array)
{
    string valuesStr = string.Empty;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (i == 0)
        {
            valuesStr = ArithmeticMeanColumn(array, i).ToString("0.00");
        }
        else
        {
            valuesStr += $"; {ArithmeticMeanColumn(array, i).ToString("0.00")}";
        }
    }
    return valuesStr;
}

int lengthOfRow = GetCount();
int lengthOfColumn = GetCount();
int[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn);
PrintMatrix(matrix);
System.Console.WriteLine($"Среднее арифметическое каждого столбца: {GetAllColumnsArifMean(matrix)}");