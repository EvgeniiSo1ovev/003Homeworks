//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7.4 22.3 2 78] -> 76

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

double PromptDouble(string msg)
{
    Console.Write(msg);
    return Convert.ToDouble(Console.ReadLine());
}

int tenDegree(int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= 10;
    }
    return result;
}

double[] GetArray(int count, double minRange, double maxRange, int frac)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        int minRangeInt = Convert.ToInt32(minRange * tenDegree(frac));
        int maxRangeInt = Convert.ToInt32(maxRange * tenDegree(frac) + 1);
        array[i] = Convert.ToDouble(new Random().Next(minRangeInt, maxRangeInt)) / tenDegree(frac);
    }
    return array;
}

void PrintArray(double[] array)
{
    string mass = $"[{array[0]}";
    for (int i = 1; i < array.Length; i++)
    {
        mass += ", " + Convert.ToString(array[i]);
    }
    mass += "]";
    Console.WriteLine(mass);
}

double DiffOfValueMinMax(double[] array)
{
	double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
	return max - min;
}

int lengthOfArray = Prompt("Введите количество элементов массива: ");
double minOfArr = PromptDouble("Введите минимальный порог случайных значений: ");
double maxOfArr = PromptDouble("Введите максимальный порог случайных значений: ");
int fracOfNumber = Prompt("Введите максимальное количество возможных знаков после запятой для вещественных чисел: ");
double[] array = GetArray(lengthOfArray, minOfArr, maxOfArr, fracOfNumber);
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {DiffOfValueMinMax(array):f2}");