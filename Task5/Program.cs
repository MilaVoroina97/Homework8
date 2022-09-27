
//Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int size = 4;
int[,] spiralMatrix = new int[size,size];
int temp = 1;
int i = 0;
int j = 0;



while(temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
    spiralMatrix[i,j] = temp;
    temp++;
    if(i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1) j++;

    else if (i < j && i + j >= spiralMatrix.GetLength(0) -1) i++;

    else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1) j--;

    else i--;
}

PrintArray(spiralMatrix);

void PrintArray(int[,] newarray)
{
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0; j < newarray.GetLength(1); j++)
        {
            if(newarray[i,j]/ 10 <= 0) Console.Write($"{newarray[i,j]} ");
            else Console.Write($"{newarray[i,j]} ");
        }
        Console.WriteLine();
    }
}

