// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double PromptDouble(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

int tenDegree(int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= 10;
    }
    return result;
}

double[,] GetMatrix(int row, int column, double minRange, double maxRange, int frac)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minRangeInt = Convert.ToInt32(minRange * tenDegree(frac));
            int maxRangeInt = Convert.ToInt32(maxRange * tenDegree(frac) + 1);
            array[i, j] = Convert.ToDouble(new Random().Next(minRangeInt, maxRangeInt)) / tenDegree(frac);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
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

int lengthOfRow = Prompt("Введите количество строк матрицы: ");
int lengthOfColumn = Prompt("Введите количество столбцов матрицы: ");
double minOfMatrix = PromptDouble("Введите минимальный порог случайных значений: ");
double maxOfMatrix = PromptDouble("Введите максимальный порог случайных значений: ");
int fracOfNumber = Prompt("Введите максимальное количество возможных знаков после запятой для вещественных чисел: ");
double[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn, minOfMatrix, maxOfMatrix, fracOfNumber);
PrintMatrix(matrix);