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

