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
            //result[i,j]= new Random().NextDouble();// Функция для случайного числа от 0.0 до 0.9 включительно
            
            result[i, j] = new Random().Next(-100, 100) + new Random().NextDouble();// Это первый вариант (берем слуйчайное целое число от -100 
            //до 100 и прибавляем к нему случайное число формата double от 0.0 до 0.9 по функции NextDouble, пример 50+0.8 = 50.8 или -8+0.1=-7.9 и т.д)
            
            //result[i, j] = new Random().Next(-100, 100) / 10.0; //Это второй вариант (берем рандомное число от -100 до 100 и делим 
            //его на число в формате double (обязательно с точкой), тогда получим целое число например 50/10.0 = 5.0 или -9/10.0 = -0.9 и т.д)
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
            Console.Write($"{Matr[i, j]:f1} "); // :f1 - означает сколько символов будет после запятой в числе double.
            //Console.Write($"{Matr[i, j]} "); вывод для второго варианта // здесь не нужно :f1, так как в функции целое 
            //число делим на 10, это значит, что после заяптой и так будет только 1 символ.
        }
        Console.WriteLine();
    }
}

