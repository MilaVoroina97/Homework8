// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4 // 2 * 3 + 4 * 3 = 18;    2 * 4 + 4 * 3 = 20;
//3 2 | 3 3 // 3 * 3 + 2 * 3 = 15;    3 * 4 + 2 * 3 = 18;
//Результирующая матрица будет:
//18 20
//15 18
try
{
    Console.WriteLine("Введите размеры двух матриц:");
    int m = NumbersInput("Введите число строк первой матрицы:");
    int n = NumbersInput("Введите число столбцов первой матрицы и число строк второй матрицы:");
    int k = NumbersInput("Введите число столбцов второй матрицы:");
    int[,] firstMatrix = new int[m,n];
    FillArray(firstMatrix);
    Console.WriteLine("Первая матрица: ");
    PrintArray(firstMatrix);
    Console.WriteLine();
    int[,] secondMatrix = new int[n,k];
    FillArray(secondMatrix);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(secondMatrix);
    Console.WriteLine();
    int[,] resultMatrix = new int[m,k];
    MatrixMultiplication(firstMatrix,secondMatrix,resultMatrix);
    Console.WriteLine("Результат умножения двух матриц: ");
    PrintArray(resultMatrix);
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целые и положительные числа.");
}

int NumbersInput (string input)
{
    Console.Write(input);
    int newInput = Convert.ToInt32(Console.ReadLine());;
    return newInput;

}

void FillArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}
void PrintArray(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int result = 0;
            for(int l = 0; l < firstMatrix.GetLength(1); l++)
            {
                result += firstMatrix[i,l] * secondMatrix[l,j];
            }
            resultMatrix[i,j] = result;
        }
    }
}


