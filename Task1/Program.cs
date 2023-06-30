/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine()!);

double[,] newarray = FillArray(col, row);
PrintArray(newarray);


double[,] FillArray(int row, int col)
{
    double[,] result = new double[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            //result[i,j]= new Random().NextDouble();
            result[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double[,] Matr)
{
    for (int i = 0; i < Matr.GetLength(0); i++)
    {
        for (int j = 0; j < Matr.GetLength(1); j++)
        {
            Console.Write($"{Matr[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

