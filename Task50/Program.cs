/*
Задача 50. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

Ввод:
1
2
Вывод:
4
*/

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            //Console.Write(matrix[i, j] + " \t");
            Console.Write("{0,4}", matrix[i, j]);
        Console.WriteLine();
    }
}

void FindElement(int[,] matrix, int i, int j)
{
    Console.WriteLine();
    if (i - 1 >= 0 && i - 1 < matrix.GetLength(0) && j - 1 >= 0 && j - 1 < matrix.GetLength(1))
    {
        Console.Write($"Значение элемента массива c номером ({i},{j}) = {matrix[i - 1, j - 1]}");
        Console.WriteLine();
    }
    else Console.Write($"Элемента с заданым номером ({i},{j}) - нет");
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите номер строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int j = Convert.ToInt32(Console.ReadLine());
FindElement(matrix, i, j);