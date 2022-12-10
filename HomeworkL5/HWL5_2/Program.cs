//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int SummOfOddIndex(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i+=2)
	{
		sum += array[i];
	}
	return sum;
}

int lengthOfArray = Prompt("Введите количество элементов массива: ");
int minOfArr = Prompt("Введите минимальный порог случайных значений: ");
int maxOfArr = Prompt("Введите максимальный порог случайных значений: ");
int[] array = GetArray(lengthOfArray, minOfArr, maxOfArr);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {SummOfOddIndex(array)}");