// Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

string Prompt(string msg)
{
    System.Console.Write(msg);
    return Console.ReadLine();
}

double[] StringToArray(string strOfNum)
{
    string[] strArray = strOfNum.Split(", ");
    double[] arrOfDouble = new double[strArray.Length];
    for (int i = 0; i < strArray.Length; i++)
    {
        arrOfDouble[i] = Convert.ToDouble(strArray[i]);
    }
    return arrOfDouble;
}

int GetCountOfBiggerThanZero(double[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

string stringOfNumbers = Prompt("Введите последовательно числа через запятую и пробел (например: 0, 7, 8, -2, -2): ");
double[] array = StringToArray(stringOfNumbers);
System.Console.WriteLine($"Количество введенных чисел, которые больше 0, равно {GetCountOfBiggerThanZero(array)}");