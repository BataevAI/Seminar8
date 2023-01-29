// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Метод создания матрицы с количеством rows строк, количеством columns столбцов и минимальный и максимальным диапозоном чисел
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
// метод печати матрицы

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

// метод вывода массива максимальных значений матрицы

int[] MinValueOfColumnsMatrix(int[,] matrix)
{
        int sum = 0;
         
        int[] arrayOfSum = new int[matrix.GetLength(0)];



            for (int i = 0; i < matrix.GetLength(0); i++) 
                {             
        
                        for (int k = 0; k < matrix.GetLength(1); k++) 
                        {
                    
                           sum = sum + matrix[i,k];
                       
                        }
                    arrayOfSum[i] = sum; 
   
                    Console.WriteLine ($"Значение суммы {i} - й строки: {arrayOfSum[i]}");
                    sum = 0;
                }

  //foreach(var item in arrayOfSum) {Console.Write(item + " | ");} - вывод массива суммы элементов

   return arrayOfSum;
}

// Метод поиска индекса максимального элемента в массиве

int MinOfRowOfArray(int[] Arr) {
   int row = 0;
   for (int i = 1; i < Arr.Length; i++ ) 
   {
        
        if (Arr[i] < Arr[row]) row = i;

   }
    return row;
}

// константы для создания массива случайных целых чисел
const int ROWS = 5;
const int COLUMNS = 4;
const int LEFTRANGE = 0;
const int RIGHTRNGE = 30;


int[,] baseArray = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRNGE); // создаем матрицу
PrintMatrix(baseArray);
Console.WriteLine();
int[] minValueOfMatrix = MinValueOfColumnsMatrix(baseArray);             //получаем массив минимальных элементов матрицы по строкам
Console.WriteLine();

int minRows = MinOfRowOfArray(minValueOfMatrix);
Console.WriteLine();


Console.WriteLine($"Наименьшая сумма: {minValueOfMatrix[minRows]} в {MinOfRowOfArray(minValueOfMatrix)}-й строке");