// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = NumbersInput("Введите число матриц X: ");
int n = NumbersInput("Введите число строк матрицы Y: ");
int k = NumbersInput("Введите число столбцов матрицы Z: ");
int[,,] result = new int[m,n,k];
FillArray(result);
PrintArray(result);
int NumbersInput (string input)
{
    Console.Write(input);
    int newInput = Convert.ToInt32(Console.ReadLine());;
    return newInput;

}


void PrintArray (int[,,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int l = 0; l < matrix.GetLength(2); l++)
      {
        Console.Write( $"Z({l})={matrix[i,j,l]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FillArray (int[,,] matrix)
{
    int[] temp = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int number = 0;
    for(int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if(i >= 1)
        {
            for(int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
          
            }
        }
    }
    int count = 0;
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int l = 0; l < result.GetLength(2); l++)
            {
                result[i,j,l] = temp[count];
                count++;
            }
        }
    }

}


