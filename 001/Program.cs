/* Задайте двумерный массив размером m×n, 
заполненный случайными
 вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}


float[,] InitMatrix(int firstValue, int secondValue)
{
    float[,] matrix = new float [firstValue, secondValue];
    Random rnd = new Random();
for(int i = 0; i < firstValue; i++)
{
    for(int j = 0; j < secondValue; j++)
    matrix [i,j] = rnd.Next (-100, 100);
}
return matrix;
}


void PrintMatrix(float[,] matrix)
{
    for(int i = 0; i <matrix.GetLength(0); i++)
    {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
         Console.Write($" {matrix[i, j]}   ");
    }
     Console.WriteLine();
     }
}

int firstValue = GetValue("m = : ");
int secondValue = GetValue("n = : ");

float[,] matrix = InitMatrix( firstValue, secondValue);
PrintMatrix(matrix);