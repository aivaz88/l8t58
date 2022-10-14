// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] matrix1 = RandomArray(4, 4);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = RandomArray(4, 4);
PrintArray(matrix2);
Console.WriteLine();
PrintArray(MultiplyMatrix(matrix1, matrix2));

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                sum += matrix1[i,k] * matrix2[k,j];    
            }
            resultMatrix[i,j] = sum;
        }
    }
    return resultMatrix;
}

int[,] RandomArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random randGenerator = new Random();
    for (int i = 0; i < m; i++) for (int j = 0; j < n; j++) newArray[i, j] = randGenerator.Next(0, 10);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++) Console.Write($"{newArray[i, j]} ");
        Console.WriteLine("");
    }
}