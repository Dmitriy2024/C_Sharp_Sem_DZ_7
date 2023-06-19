// Задать двумерный массив m*n, заполненый случайными числами.
//m=3, n=4.
//1 2 8 9
//5 -2 33 -2
//77 3 8 1
/*
Console.Write("Введите кол-во строк;");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите кол-во столюцов;");
int colums = Convert.ToInt32(Console.ReadLine());

//int[,] resMartrix = GetMatrix(rows, colums, 0, 10)

int[,] GetMatrix(int m, int n, int min, int max)
{
int[,] matrix = new int[m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = new Random().Next(min, max + 1);
    }
    }
    return matrix;
}
void PrintMatrix(int[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
   {
    for(int j = 0; j < array.GetLength(0); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
   }
}
*/

/*
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами.
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] resArray = GetMatrix(m, n); 

PrintMatrix(resArray);

double[,] GetMatrix(int m, int n)
{
double[,] matrix = new double[m,n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = Math.Round(new Random().NextDouble() * 10, 2);
    }
}
        return matrix;
}

void PrintMatrix(double[,] array)
{
 for(double i = 0; i < array.GetLength(0); i++)
   {
    for(double j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[(int)i, (int)j] + "\t");
    }
    Console.WriteLine();
   }
}
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите индекс m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс n: ");
int n = Convert.ToInt32(Console.ReadLine());
int row = 3;
int column = 4;

int[,] resArray = GetMatrix(row, column); 
PrintMatrix(resArray);


int[,] GetMatrix(int m, int n)
{
int[,] matrix = new int[row, column];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j <matrix.GetLength(1); j++)
   {
        matrix[i,j] = matrix[i,j] = new Random().Next(0, 100 + 1);
    }
}
        return matrix;

}
void PrintMatrix(int[,] array)
{
 for(int i = 0; i < array.GetLength(0); i++)
  
   {
      for(int j = 0; j < array.GetLength(1); j++)
       {
        Console.Write(array[i, j] + "\t");
       }
       Console.WriteLine();
   }
} 
if(m > row || n > column)
{
  Console.Write("Эленент не существует");
}
else
{
   
    Console.Write("Значение злемента = " + resArray[m-1, n-1] );
}  
