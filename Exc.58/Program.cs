// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] GetRandomMatrix1(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
// метод печати матрицы

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write("  " + matrix[i, j] + "|");
            else if (matrix[i, j] >= 10 && matrix[i, j] < 100) Console.Write(" " + matrix[i, j] + "|");
            else Console.Write(matrix[i, j] + "|");
        }
        Console.WriteLine();
    }
}

    int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
    {
        int[,] matrixTotal = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
    

            for(int k = 0; k < matrix1.GetLength(0); k++)
    
                    {
                for(int i = 0; i < matrix1.GetLength(0); i++)
                        {
                            int sum = 0;
                            for(int j = 0; j < matrix1.GetLength(1); j++)
                                {
                                        sum = sum + (matrix1[k,j] * matrix2[j,i]);
                             
                                        matrixTotal[k, i] = sum;
                                }
               

                        }
    
                    }
        return matrixTotal;
    }

// Задаем матрицы вручную 

int[,] m1 = {
            {1,2,3,4},
            {4,5,6,7},
            {1,0,2,3}   };

int[,] m2 = {
            {7, 10, 1},
            {8, 11, 1},
            {9, 12, 1},
            {1,  3, 1}    };
   Console.WriteLine("Произведение матриц m1 размером (3x4) и m2 размером (4x3) - является новая матрица 3х3 :");         
PrintMatrix(ProductMatrix(m1,m2));

//или же используем случайные матрицы
Console.WriteLine("или же используем случайные матрицы");
int[,] mtrx1 = GetRandomMatrix1(3,2,1,5);
PrintMatrix(mtrx1);
Console.WriteLine();
int[,] mtrx2 = GetRandomMatrix1(2,3,1,8);
PrintMatrix(mtrx2);
Console.WriteLine("получаем итоговую: ");
Console.WriteLine();
PrintMatrix(ProductMatrix(mtrx1,mtrx2));

Console.WriteLine("Я сделал это!!!");

