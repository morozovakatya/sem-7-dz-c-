/* Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и 
возвращает значение этого элемента или же 
указание, что такого элемента нет.
*/



void InitMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
 {
    for(int j = 0; j <matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
 }
}


void PrintMatrix(int[,] matrix)
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

int GetValue( string message)
{
  Console.WriteLine(message);
  int value = int.Parse(Console.ReadLine());
  return value;
}
  
    
  int GetNumber(int firstValue, int secondValue, int[,] matrix)
  {
    if(firstValue > matrix.GetLength(0) 
       && secondValue > matrix.GetLength(1))
       {
         Console.Write("Такого числа нет");
       }
      else
         {
           Console.Write($"{matrix[firstValue,secondValue]}");
          }
  }      



  int[,] matrix = new int[4, 4];
  int firstValue = GetValue("Введите номер строки: ");
  int secondValue = GetValue("Введите номер столбца: ");
  InitMatrix (matrix);
  PrintMatrix(matrix);
  GetNumber(firstValue, secondValue, matrix); 