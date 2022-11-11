// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Random random = new Random();

int [,] array = new int[random.Next(1, 10), random.Next(1, 10)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write($" {array[i, j]}" + " ");
    }
    Console.WriteLine();
}

int[] temp = new int[array.GetLength(1)];
 
            Console.WriteLine("Сортировка по строкам: ");
   for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    temp[j] = array[i, j];
                Array.Sort(temp);
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    array[i, k] = temp[k];
                    Console.Write($" {array[i, k]}" + " " );
                }
                Console.WriteLine();
            }

