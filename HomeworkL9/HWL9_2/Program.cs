//Задача 2: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int Prompt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int numberM, int numberN)
{
	if (numberM > numberN)
	{
		return 0;
	}
	return numberM + SumNumbers(numberM+1, numberN);
}

int numberM = Prompt("Введите первое число: ");
int numberN = Prompt("Введите второе число: ");
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} равна {SumNumbers(numberM, numberN)}");