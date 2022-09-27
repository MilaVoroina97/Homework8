// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

try
{
    Console.WriteLine("Введите число строк двумерного массива:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число столбцов двумерного массива:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int[,] newarray = new int[m,n];
    FillArray(newarray);
    Console.WriteLine("Изначальный массив: ");
    PrintArrayTwo(newarray);
    int[] table = new int[m*n];
    int x = 0;
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0 ; j < newarray.GetLength(1); j++)
        {
            table[x] = newarray[i,j];
            x++;
            
        }
    } 
    SortArray(table);
    Console.WriteLine();
    int[,] newarray2 = new int[m,n];
    int z = 0;
    for(int i = 0; i < newarray2.GetLength(0); i++)
    {
        for(int j = 0 ; j < newarray2.GetLength(1); j++)
        {
            newarray2[i,j] = table[z];
            z++;
            
        }
    }
    Console.WriteLine("Отсортированный массив: ");
    PrintArrayTwo(newarray2);  
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
            matrix[i,j] = new Random().Next(1,100);
        }
    }
}
void PrintArrayTwo(int[,] matrix)
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


void SortArray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int max_position = i;
        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[max_position]) 
            {
                max_position = j;
            }
        }
        int temp = array[i];
        array[i] = array[max_position];
        array[max_position] = temp;
    }
}