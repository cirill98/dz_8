// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] array = new int[3, 3, 3];

// void Fill3DArrNonRepeat(int[,,] arr)
// {
//     for (int k = 0; k < arr.GetLength(2); k++)
//     {
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//             Repart:
//                 int check = new Random().Next(10, 100) * (new Random().Next(0, 2) * 2 - 1);
//                 int k1, i1, j1;
//                 for (k1 = 0; k1 = arr.GetLength(2); k1++)
//                 {
//                     for(i1 = 0; i1 < arr.GetLength(0); i1++)
//                     {
//                         for (j1 = 0; j1 < arr.GetLength(1); j1++)
//                         {
//                             if (arr[i1, j1, k1] == check)
//                             {
//                                 goto Repart;
//                             }
//                             if ((i1 == i) && (j1 == j) && (k1 == k))
//                             {
//                                 arr[i, j, k] = check;
//                                 break;
//                             }
//                         }
//                     }
//                 }
//             }
//         }
//     }
// }
// void PrintArray(int[,,] arr)
// {
//     for (int k = 0; k < arr.GetLength(2); k++)
//     {
//         Console.WriteLine($"Block {k}-----------------------------");
//         for (int i = 0; i < arr.GetLength(0); i++)
//         {
//             Console.Write("|");
//             for (int j = 0; j < arr.GetLength(1); j++)
//             {
//                 Console.WriteLine("{0,14}", $"{arr[i, j, k]} ({i}):({j}):({k})");
//             }
//             Console.WriteLine();
//             Console.WriteLine();
//         }
//         Console.WriteLine("--------------------------------------------------");
//     }
// }
// Fill3DArrNonRepeat(array);
// PrintArray(array);
int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 10;
int maxNumber = 99;
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];

Console.Clear();
FillArrayRandomNumber(testArray, minNumber, maxNumber);
PrintArrayWithIdex(testArray);

void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                while (array[i, j, h] == 0)
                {
                    int number = rand.Next(minNumber, maxNumber + 1);

                    if (IsNumberInArray(array, number) == false)
                    {
                        array[i, j, h] = number;
                    }
                }

            }
        }
    }
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}