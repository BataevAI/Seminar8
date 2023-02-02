﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// метод вывода чисел двухмерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write("0" + matrix[i, j] + " |");
            else Console.Write(matrix[i, j] + " |");
        }
        Console.WriteLine(); //string s1 = i.ToString();
    }
}
// Метод заполнения матрицы по спирали

int[,] SpiralMatrix(int[,] arr) {

int count = 1;
int i = 0;
int j = 0;
int dimensionOfMatrix = arr.GetLength(0);

while (count <= Math.Pow(dimensionOfMatrix,2))
{
   arr[i, j] = count;

    if (i <= j + 1 && i + j < dimensionOfMatrix - 1)
        ++j;
    else if (i < j && i + j >= dimensionOfMatrix - 1)
        ++i;
    else if (i >= j && i + j > dimensionOfMatrix - 1)
        --j;
    else
        --i;
    ++count;
}

return arr;
}
Console.WriteLine("Введите размерность матрицы, которую будем заполнять");
int numberOfMatrix = Convert.ToInt32(Console.ReadLine());

int[,] TotalMatrix = new int[numberOfMatrix, numberOfMatrix];
PrintMatrix(SpiralMatrix(TotalMatrix));