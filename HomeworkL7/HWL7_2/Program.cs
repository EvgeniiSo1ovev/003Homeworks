/* Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Ряд > 1
Колонка > 7
1, 7 -> такого числа в массиве нет */

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCount()
{
    return new Random().Next(1, 11);
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

bool ValidateCoord(int[,] array, int row, int column)
{
    if (array.GetLength(0) >= row && array.GetLength(1) >= column)
    {
        return true;
    }
    return false;
}

int GetNumberArray(int[,] array, int row, int column)
{
    return array[row-1, column-1];
}

int lengthOfRow = GetCount();
int lengthOfColumn = GetCount();
int[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn);
int userRow = Prompt("Введите номер ряда (от 1 до 10): ");
int userColumn = Prompt("Введите номер колонки (от 1 до 10): ");
PrintMatrix(matrix);
if (ValidateCoord(matrix, userRow, userColumn))
{
    System.Console.WriteLine($"Значение элемента с заданными параметрами (ряд: {userRow}, колонка: {userColumn}) в указанном в массиве равно {GetNumberArray(matrix, userRow, userColumn)}.");
}
else
{
    System.Console.WriteLine($"Элемента с заданными параметрами (ряд: {userRow}, колонка: {userColumn}) в указанном в массиве нет.");
}
