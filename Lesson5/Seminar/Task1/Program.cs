﻿void Main()
{
    int row = ReadInt("Введите количество строк: ");
    int col = ReadInt("Введите количество столбцов: ");
    int[,] matrix = GenerateMatrix(row, col, 0, 99);
    PrintMatrix(matrix);
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] GenerateMatrix(int rowSize, int colSize, int minValue, int maxValue)
{
    int[,] tempMatrix = new int[rowSize, colSize];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }

    return tempMatrix;
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();