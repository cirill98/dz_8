// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// Console.WriteLine("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите m: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[m, n];
// void FillArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = new Random().Next(0, 10);
//         }
//     }
// }
// void PrintArray(int[,] arr)
// {
//       for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// void SumArray(int[,] arr)
// {
//     int minSumLine = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             sum += arr[i, j];
//         }
//         Console.WriteLine($"{sum} \t");
//         int sumLine = sum[array, 0];
//         int tempSumLine = sum;
    
//     }
// }
// void MinSumArray(int[,] arr)
// {
//     int minSumLine = 0;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {

//     }
// }

// for (int i = 1; i < array.GetLength(0); i++)
// {
//     int tempSumLine = SumLineElements(array, i);
//     if (sumLine > tempSumLine)
//     {
//         sumLine = tempSumLine;
//         minSumLine = i;
//     }
// }


// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Сумма элементов в каждой строке: ");
// SumArray(array);
// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой элементов ");

Console.Clear();
Console.WriteLine($"Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
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