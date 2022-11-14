void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                matrix[i, j, k] = new Random().Next(0, 11);
        }
    }
}

void PrintMatrix(int[,,] MatrixOne)
{
    for (int i = 0; i < MatrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < MatrixOne.GetLength(1); j++)
        {
            for (int k = 0; k < MatrixOne.GetLength(2); k++)
                Console.WriteLine(MatrixOne[i, j, k] + " (" + i + ", " + j + ", " + k +")");
        }
    }
}

Console.Clear();
Console.Write("Введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] MatrixOne = new int[x, y, z];
InputMatrix(MatrixOne);
PrintMatrix(MatrixOne);
