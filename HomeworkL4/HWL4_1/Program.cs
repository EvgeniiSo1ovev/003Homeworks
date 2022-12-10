//Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B. Реализовать через функции.

int Prompt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int Degree(int number, int degreeOfNumber)
{
	int result = 1;
	for (int i = 1; i <= degreeOfNumber; i++)
	{
		result *= number;
	}
	return result;
}

int A = Prompt($"Введите число: ");
int B = Prompt($"Введите натуральное число (степень): ");
Console.WriteLine($"Число {A} в степени {B} равно {Degree(A, B)}");