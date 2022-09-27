// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
try
{
    Console.WriteLine("Введите число строк двумерного массива:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов двумерного массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] newarray = new int[m,n];

    if(m == n) Console.WriteLine("Вводимые числа не должны быть равны друг другу, так как мы задаем прямоугольный массив");
    else
    {
        
        FillArray(newarray);
        PrintArray(newarray);
        int minsumindex = 0;
        int newsum = SumOfRows(newarray,0);
        for(int i = 0; i < newarray.GetLength(0); i++)
        {
            int temp = SumOfRows(newarray,i);
            if(newsum > temp)
            {
                newsum = temp;
                minsumindex = i;
            }
        }
        Console.WriteLine($"Строка с минимальной суммой элементов {newsum} : {minsumindex+1} строка");
    }
}
catch
{
    Console.WriteLine("Введите, пожалуйста, целые и положительные числа.");
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

int SumOfRows(int[,] newarray, int i)
{
     
    int sum = newarray[i,0];
    for(int j = 0; j < newarray.GetLength(1); j++)
    {
        sum += newarray[i,j];
    }

    Console.WriteLine($"Сумма элементов {i+1} строки равна: {sum}");
    return sum;
}






