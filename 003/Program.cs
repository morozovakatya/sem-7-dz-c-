/*Задайте двумерный массив из целых чисел. Найдите среднее
арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] InitMatrix(int firstValue, int secondValue)
{
    int[,] matrix = new int[firstValue, secondValue];
    Random rnd = new Random();
    for (int i = 0; i < firstValue; i++)
    {
        for (int j = 0; j < secondValue; j++)
            matrix[i, j] = rnd.Next(1, 10);
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] matrix)
{
    double sum = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i,j];
        }
        double average = sum / matrix.GetLength(1);
        Console.WriteLine($"среднее арифметическое столбца {j} = {average}");
        sum = 0;
    }
    
}


int firstValue = GetValue("Введите количество строк : ");
int secondValue = GetValue("Введите количество столбцов: ");

int[,] matrix = InitMatrix(firstValue, secondValue);
PrintMatrix(matrix);
FindAverage(matrix);

//matr.GetLength(0) - строки 
//matr.GetLength(1) - столбцы
//пройтись по каждому столбцу и сложить значения в переменную




