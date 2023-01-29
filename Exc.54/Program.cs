// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Метод создания массива с количеством rows строк, количеством columns столбцов и минимальный и максимальным диапозоном чисел
int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
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

// метод вывода чисел двухмерного массива

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) Console.Write(" " + matrix[i, j] + " |");
            else Console.Write(matrix[i, j] + " |");
        }
        Console.WriteLine();
    }
}

//метод сортировки в порядке убывания в каждой строке двухмерного массива
int[,] RangeNewMatrix(int[,] matrix)
{
        
            for (int i = 0; i < matrix.GetLength(0); i++) 
                {

                for (int j = 0; j < matrix.GetLength(1); j++)
                    {
        
                        for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++) 
                        {
                    
                            if (matrix[i, k + 1] > matrix[i, k]) 
                                {
                                        int temp = matrix[i, k + 1]; 
                                        matrix[i, k + 1] = matrix[i, k];
                                        matrix[i, k] = temp;
                                }   
                                                                                  

                        }
                    }
                    
                }
    return matrix;
}

// константы для создания массива случайных целых чисел
const int ROWS = 10;
const int COLUMNS = 10;
const int LEFTRANGE = 0;
const int RIGHTRNGE = 30;


int[,] baseArray = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRNGE);
PrintMatrix(baseArray);
Console.WriteLine();
RangeNewMatrix(baseArray);

PrintMatrix(baseArray);

