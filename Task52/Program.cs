/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 11);
    }
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            //Console.Write(matrix[i, j] + " \t");
            Console.Write("{0,5}", matrix[i, j]);
        Console.WriteLine();
    }
}


double[] AvgColumn(double[,] matrix)
{
    double avgrow;
    double[] avgarray = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        avgrow = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
            avgrow = avgrow + matrix[i, j];

        avgarray[j] = Math.Round(avgrow / matrix.GetLength(0),1);
    }
    return avgarray;
}

//Закомментировать для автозаполнения массива
double[,] matrix = new double[,]
{   {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
//

/* Раскомментировать для автозаполнения массива
Console.Write("Введите количество строк матрицы N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
*/

PrintMatrix(matrix);
AvgColumn(matrix);
Console.WriteLine(string.Join("; ", AvgColumn(matrix)));