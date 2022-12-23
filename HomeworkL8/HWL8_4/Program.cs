/* Задача 4. (*) Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int GetCount()
{
    return new Random().Next(4, 5);
}

(int[,], int) FillRowOfMatrix(int[,] array, int rowTo,
                            int indexRow, int beginindex,
                            int endindex, int number)
{
    for (int i = beginindex; rowTo*i <= rowTo*endindex; i += rowTo)
    {
        array[indexRow, i] = number;
        number++;
    }
    return (array, number);
}

(int[,], int) FillColumnOfMatrix(int[,] array, int columnTo,
                                int indexColumn, int beginindex,
                                int endindex, int number)
{
    for (int i = beginindex; columnTo*i <= columnTo*endindex; i += columnTo)
    {
        array[i, indexColumn] = number;
        number++;
    }
    return (array, number);
}

(int[,], int, int, int, int, int, int, int) FillOneRowOrColumnOfMatrix(int[,] array, int rowTo, int columnTo,
                                                                    int topRow, int bottomRow,
                                                                    int leftColumn, int rightColumn,
                                                                    int number)
{
    if (columnTo == 0 && rowTo == 1)
    {
		(array, number) = FillRowOfMatrix(array, rowTo,
                                            topRow, leftColumn,
                                            rightColumn, number);
        topRow++; 
        rowTo = 0; columnTo = 1;
    }
	else if (columnTo == 0 && rowTo == -1)
    {
        (array, number) = FillRowOfMatrix(array, rowTo,
                                            bottomRow, rightColumn,
                                            leftColumn, number);
        bottomRow--; rowTo = 0; columnTo = -1;
	}
	else if (columnTo == 1)
    {
        (array, number) = FillColumnOfMatrix(array, columnTo,
                                            rightColumn, topRow,
                                            bottomRow, number);
        rightColumn--; rowTo = -1; columnTo = 0;
    }
    else
    {
        (array, number) = FillColumnOfMatrix(array, columnTo,
                                            leftColumn, bottomRow,
                                            topRow, number);
        leftColumn++; rowTo = 1; columnTo = 0;
    }
    return (array, rowTo, columnTo,
            topRow, bottomRow,
            leftColumn, rightColumn,
            number);
}

int[,] GetSpiralMatrix(int row, int column)
{
    int number = 1;
    int rowTo = 1; 
    int columnTo = 0;
    int[,] array = new int[row, column];
    int topRow = 0;
    int bottomRow = row - 1;
    int leftColumn = 0;
    int rightColumn = column - 1;
    while (number <= array.Length)
    {
        (array, rowTo, columnTo,
        topRow, bottomRow,
        leftColumn, rightColumn,
        number) = FillOneRowOrColumnOfMatrix(array, rowTo, columnTo,
                                        topRow, bottomRow,
                                        leftColumn, rightColumn,
                                        number);
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

int lengthOfRow = GetCount();
int lengthOfColumn = GetCount();
int[,] matrix = GetSpiralMatrix(lengthOfRow, lengthOfColumn);
PrintMatrix(matrix);