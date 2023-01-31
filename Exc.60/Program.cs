// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// метод формирования случайной матрицы
int[, ,] GetRandomMatrix1(int rows, int columns, int deep)
{
    int[, ,] matrix = new int[rows,columns,deep];
   

       
       
        

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++) 
                {
                    // мой личный рандомайзер ))

                
                        int rand = 10 + 4 * i + 5 * j + 6 * k + (i + 1) * (j + 2) * (k + 4);
                    if (rand > 99) {rand = rand - 48; matrix[i, j, k] = rand;}
                    else if (rand < 10) {rand = Math.Abs(rand) + 56; matrix[i, j, k] = rand;}
                    else {matrix[i, j, k] = 10 + 4 * i + 5 * j + 6 * k + (i + 1) * (j + 2) * (k - 1);}
                }
        }
    }

    
    return matrix;
}

void PrintMatrix(int[, ,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] < 10) Console.Write($"  {matrix[i, j, k]}({i}, {j}, {k})| ");
                else if (matrix[i, j, k] >= 10 && matrix[i, j, k] < 100) Console.Write($" {matrix[i, j, k]}({i}, {j}, {k})|");
                else Console.Write($"{matrix[i, j, k]}({i}, {j}, {k})|");
            }
        Console.WriteLine();
        }
        Console.WriteLine();
    }
     
}

const int r = 3;
const int c = 3;
const int d = 3;
PrintMatrix(GetRandomMatrix1(r, c, d));