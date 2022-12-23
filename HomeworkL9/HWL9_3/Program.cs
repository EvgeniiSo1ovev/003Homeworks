//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Prompt(string msg)
{
	Console.Write(msg);
	return Convert.ToInt32(Console.ReadLine());
}

int Ackerman(int numberM, int numberN)
{
	if (numberM == 0)
	{
		return numberN + 1;
	}else if (numberN == 0)
	{
		return Ackerman(numberM - 1, 1);
	}else 
	{
		return Ackerman(numberM-1, Ackerman(numberM, numberN - 1));
	}
}

int numberM = Prompt("Введите первое натуральное число (не более 3): ");
int numberN = Prompt("Введите второе натуральное число (не более 3): ");
Console.WriteLine($"А({numberM}, {numberN}) = {Ackerman(numberM, numberN)}");