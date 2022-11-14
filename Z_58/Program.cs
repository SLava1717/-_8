/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ProzMatrix(int[,] MatrixOne, int[,] MatrixTwo)
{
    Console.WriteLine();
    int[,] ResultMatrix = new int[MatrixOne.GetLength(0),MatrixOne.GetLength(1)];
    for (int i = 0; i <MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j <MatrixOne.GetLength(1); j++)
            {
                ResultMatrix[i, j] = MatrixOne[i, j] * MatrixTwo[i, j];
                Console.Write(ResultMatrix[i, j] + " \t");
            }    
            Console.WriteLine();
    } 
}   




Console.Clear();
Console.Write("Введите кол-во строк и столбцов через пробел: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] MatrixOne = new int[n, m];
int[,] MatrixTwo = new int[n, m];
Console.WriteLine("Begin 1: ");
InputMatrix(MatrixOne);
Console.WriteLine();
Console.WriteLine("Begin 2: ");
InputMatrix(MatrixTwo);
Console.WriteLine("Result: ");
ProzMatrix(MatrixOne, MatrixTwo);