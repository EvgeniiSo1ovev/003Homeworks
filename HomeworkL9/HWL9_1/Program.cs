//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Prompt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

bool IsEven(int number)
{
	return number % 2 == 0;
}

void PrintEvenNumbers(int numberM, int numberN)
{
	if (numberM > numberN)
	{
		return;
	}
	if (IsEven(numberM))
	{
		Console.Write($"{numberM}; ");
	}
	PrintEvenNumbers(numberM+1, numberN);
}

int numberM = Prompt("Введите первое натуральное число: ");
int numberN = Prompt("Введите второе натуральное число: ");
PrintEvenNumbers(numberM, numberN);