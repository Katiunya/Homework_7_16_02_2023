// Задача 47. Задайте двумерный массив размером m×n, заполненный 
// случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7    -2   -0,2
//   1  -3,3   8   -9,9
//   8   7,8  -7,1  9
/*
Console.WriteLine("Input the count of rows: ");
int rowsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the count of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rowsVol, columnsVol];
FillArrayRandom(numbers);
ShowArray(numbers);

void FillArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/
// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Input the count of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the count of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
FillArrayRandom(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("There is no such number in the array.");
}
else
{
    Console.WriteLine($"Value of the element {n} row and {m} column is {numbers[n-1,m-1]}");
}

ShowArray(numbers);

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.WriteLine(""); 
    }
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
Console.WriteLine("Input the count of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the count of columns: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int[,] numbers = new int[n, m];
FillArrayRandom(numbers);
ShowArray(numbers);

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double arithMean = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arithMean = (arithMean + numbers[i, j]);
    }
    arithMean = arithMean / n;
    Console.Write(Math.Round(arithMean, 1) + "; ");
}
Console.WriteLine();

*/




