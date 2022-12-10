// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, 
// но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5


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
        array[i] = new Random().Next(minRange, maxRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    string mass = $"[{array[0]}";
    for (int i = 1; i < array.Length; i++)
    {
        mass += "," + Convert.ToString(array[i]);
    }
    mass += "]";
    Console.WriteLine(mass);
}

int SecondMaxValue(int[] array)
{
    int max = array[0];
    int secondMax = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max == secondMax)
        {
            if (array[i] < max)
            {
                secondMax = array[i];
            }
            else if (array[i] > max)
            {
                max = array[i];
            }
        }
        if (array[i] > max)
        {
            secondMax = max;
            max = array[i];
        }
        if (array[i] != max && array[i] > secondMax)
        {
            secondMax = array[i];
        }
    }
    return secondMax;
}

int lengthArray = Prompt("Введите длину массива: ");
int minOfArr = Prompt("Введите минимальное число массива: ");
int maxOfArr = Prompt("Введите максимальное число массива: ");
int[] arr = GetArray(lengthArray, minOfArr, maxOfArr);
PrintArray(arr);
Console.WriteLine($"Второй максимум указанного массива равен {SecondMaxValue(arr)}");