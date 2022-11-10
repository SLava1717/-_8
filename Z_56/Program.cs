/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с н
аименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
int minsum = 10000;
int k = 0; // номер строки
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            k++;
        }
    }
    Console.Write(k);
}
  



Console.Clear();
Console.Write("Введите кол-во строк и столбцов через пробел: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Begin: ");
InputMatrix(matrix);
Console.WriteLine("Result: ");
ReleaseMatrix(matrix);