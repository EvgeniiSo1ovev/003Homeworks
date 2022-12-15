//Задача 5: * Найдите максимальное значение в матрице по каждой строке, 
//получите сумму этих максимумов. Затем найдите минимальное значение 
//по каждой колонке,получите сумму этих минимумов. Затем из первой суммы 
//(с максимумами) вычтите вторую сумму(с минимумами)
//1 2 3
//3 4 5
//3+5=8, 1+2+3=6, 8-6=2

int Prompt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int row, int column)
{
	int[,] array = new int[row,column];
	for (int i = 0; i < row; i++)
	{
		for (int j = 0; i < column; i++)
		{
			array[i, j] = new Random().Next(1,10);
		}
	}
	return array;
}

int GetMaxRow(int[,] array, int irow)
{
	int max = array[irow, 0];
	for (int i = 1; i < array.GetLength(1); i++)
	{
		if (array[irow, i] > max)
		{
			max = array[irow, i];
		}
	}
	return max;
}

int SumMaxRowArray(int[,] array)
{
	int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		sum += GetMaxRow(array, i);
	}
	return sum;
}

int GetMinColumn(int[,] array, int icolumn)
{
	int min = array[0, icolumn];
	for (int i = 1; i < array.GetLength(0); i++)
	{
		if (array[i, icolumn] < min)
		{
			min = array[i, icolumn];
		}
	}
	return min;
}

int SumMinColumnArray(int[,] array)
{
	int sum = 0;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		sum += GetMinColumn(array, i);
	}
	return sum;
}

int lengthOfRow = Prompt("Введите количество строк матрицы: ");
int lengthOfColumn = Prompt("ВВедите количество столбцов матрицы: ");
int[,] matrix = GetMatrix(lengthOfRow, lengthOfColumn);
