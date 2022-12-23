/* Задача 3: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 1 | 3 4
3 2 1 | 3 3
_ _ _ | 1 1
Результирующая матрица будет:
19 21
16 19 */

int GetCount()
{
    return new Random().Next(2, 5);
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

int SumOfValueOfMultiplyRowAColumnB(int[,] arrayA, int[,] arrayB, int indexRowA, int indexColumnB)
{
    int sum = 0;
    for (int i = 0; i < arrayA.GetLength(1); i++)
    {
        sum += arrayA[indexRowA, i] * arrayB[i, indexColumnB];
    }
    return sum;
}

int[,] MultiplyMatrixes(int[,] arrayA, int[,] arrayB)
{
    int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < arrayC.GetLength(0); i++)
    {
        for (int j = 0; j < arrayC.GetLength(1); j++)
        {
            arrayC[i, j] = SumOfValueOfMultiplyRowAColumnB(arrayA, arrayB, i, j);
        }
    }
    return arrayC;
}

int lengthOfRowOfMatrixA = GetCount();
int lengthOfColumnOfMatrixA = GetCount();
int lengthOfRowOfMatrixB = lengthOfColumnOfMatrixA;
int lengthOfColumnOfMatrixB = GetCount();
int[,] matrixA = GetMatrix(lengthOfRowOfMatrixA, lengthOfColumnOfMatrixA);
int[,] matrixB = GetMatrix(lengthOfRowOfMatrixB, lengthOfColumnOfMatrixB);
System.Console.WriteLine("Произведение матрицы: ");
PrintMatrix(matrixA);
System.Console.WriteLine("на матрицу: ");
PrintMatrix(matrixB);
System.Console.WriteLine("равна матрице: ");
int[,] matrixC = MultiplyMatrixes(matrixA, matrixB);
PrintMatrix(matrixC);