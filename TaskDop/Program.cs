/*
На днях Иван у себя в прихожей выложил кафель, 
состоящий из квадратных черных и белых плиток. 
Прихожая Ивана имеет квадратную форму 4х4, вмещающую 16 плиток. 
Теперь Иван переживает, что узор из плиток, который у него получился, 
может быть не симпатичным. С точки зрения дизайна симпатичным узором 
считается тот, который не содержит в себе квадрата 2х2, состоящего из 
плиток одного цвета.

*/


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 2);
    }
}

void PrintMatrix(int[,] matrix)
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

void Pattern(int[,] matrix)
{
    int fine = 1;
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j + 1] && matrix[i, j] == matrix[i + 1, j])
                fine = 0;
        }
    }
    if (fine == 1)
        Console.WriteLine("Симпатичный узор");
    else
        Console.WriteLine("Несимпатичный узор");
}

int[,] matrix = new int[4, 4];
InputMatrix(matrix);
PrintMatrix(matrix);
Pattern(matrix);