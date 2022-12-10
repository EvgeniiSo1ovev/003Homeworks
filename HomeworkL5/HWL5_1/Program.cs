//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] GetArray(int count, int minRange, int maxRange)
{
	int[] array = new int[count];
	for (int i = 0; i < count; i++)
	{
		array[i] = new Random().Next(minRange, maxRange+1);
	}
	return array;
}

void PrintArray(int[] array)
{
	string mass = $"[{array[0]}";
	for (int i = 1; i < array.Length; i++)
	{
		mass += ", "+Convert.ToString(array[i]);
	}
	mass += "]";
	Console.WriteLine(mass);
}

int CountOfEven(int[] array)
{
	int count = 0;
	foreach (int item in array)
	{
		if (item % 2 == 0)
		{
			count++;
		}
	}
	return count;
}

int lengthOfArray = Prompt("Введите количество элементов массива: ");
int minOfArr = Prompt("Введите минимальный порог случайных значений: ");
int maxOfArr = Prompt("Введите максимальный порог случайных значений: ");
int[] array = GetArray(lengthOfArray, minOfArr, maxOfArr);
PrintArray(array);
Console.WriteLine($"Количество четных чисел в указанном массиве равно {CountOfEven(array)}");