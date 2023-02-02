// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }


void FirstMatrix(int [,] one, int [,] two) // Заполнение первого массива рандомными данными
{
    for(int i = 0; i < one.GetLength(0); i++) 
    {
        for(int j = 0; j < one.GetLength(1); j++) 
        {
            one [i,j] = new Random().Next(1,10);
            
        }
    }
    for(int y = 0; y < two.GetLength(0); y++)
    {
        for(int x = 0; x < two.GetLength(1); x++)
        {
            two [y,x] = new Random().Next(1,10);
        }
    }

}

void PrintArrayFirst(int[,] one) // Распечатывание первого массива
{
    for (int i = 0; i  < one.GetLength(0); i++) 
    {
        for (int j = 0; j < one.GetLength(1); j++) 
        {
            Console.Write($"{one[i,j]} ");
        }
    Console.WriteLine();
    }
    
}

void PrintArraySecond(int [,] two) // Распечатывание первого массива
{
        for(int y = 0; y < two.GetLength(0); y++)
    {
        for(int x = 0; x < two.GetLength(1); x++)
        {
            Console.Write($"{two[y,x]} ");
        }
    Console.WriteLine();
    }

}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)     //Функция перемножения матриц
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
      
    }
    }
}

void WriteArray (int[,] array)      // Распечатывание первого массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int i = InputNumbers("Введите число строк 1-й матрицы: ");
// int t = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");
Random rnd = new Random();
int i = rnd.Next(1, 4);
int t = rnd.Next(1, 4);
int p = rnd.Next(1, 4);

int [,] First = new int [i, t];
int [,] Second= new int [t, p];

FirstMatrix(First, Second);
Console.WriteLine($"Первая матрица:");
PrintArrayFirst(First);
Console.WriteLine();
Console.WriteLine($"Вторая матрица:");
PrintArraySecond(Second);

Console.WriteLine();

// Console.Clear();

int[,] resultMatrix = new int[i,p];
MultiplyMatrix(First, Second, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);
