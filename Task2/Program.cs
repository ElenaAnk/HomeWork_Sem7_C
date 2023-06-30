/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 7
i = 4, j = 2 -> такого элемента не существует*/

int[,] array = GetArray(3, 4, 1, 9);
PrintArray(array);
FindPosition(array);


int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] result = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindPosition(int[,] inArray)
{
    Console.Write("Введите  индекс строки: ");
    int FindRow = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Введите индекс столбца: ");
    int FindCol = Convert.ToInt32(Console.ReadLine()!);
    if (FindRow > inArray.GetLength(0) || FindCol > inArray.GetLength(1))
    {
        Console.Write("Элемент по заданным индексам не существует!");
    }
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == FindRow && j == FindCol)
            {
                Console.Write($"Элемент по заданным индексам -> {inArray[i, j]}");
            }
        }
    }
}



