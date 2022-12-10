//Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
//Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
//“Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

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
		mass += ","+Convert.ToString(array[i]);
	}
	mass += "]";
	Console.WriteLine(mass);
}

int lengthOfArray = Prompt("Введите количество элементов массива: ");
int minOfArr = Prompt("Введите минимальный порог случайных значений: ");
int maxOfArr = Prompt("Введите максимальный порог случайных значений: ");
int[] array = GetArray(lengthOfArray, minOfArr, maxOfArr);
PrintArray(array);