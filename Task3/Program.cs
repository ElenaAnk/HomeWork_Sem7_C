/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
* Сумма всех цифр / их количество(это количество ваших строк)*/

int[,] myArray = GetArray(3, 4, 1, 9);
PrintArray(myArray);
Average(myArray);

int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write($"{newArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] Array)
{

    for (int j = 0; j < Array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sum = sum + Array[i, j];
        }
        double aver = sum / Array.GetLength(0);
        Console.Write($"{aver:f2}; ");
    }
}
