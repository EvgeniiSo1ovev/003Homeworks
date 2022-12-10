// Задача 3
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    System.Console.Write($"{message} : ");
    return Convert.ToInt32(Console.ReadLine());
}

string GetCube(int n)
{
    string stringOfCube = "1";
    for (int i = 2; i <= n; i++)
    {
        stringOfCube = stringOfCube + ", " + Convert.ToString(i * i * i);
    }
    return stringOfCube;
}

int N = Promt("Введите число");
System.Console.WriteLine($"Таблица кубов чисел от 1 до {N}: {GetCube(N)}");