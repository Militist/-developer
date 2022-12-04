/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] ArrayErstellen(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void Metod(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{i}-ая итерация: ");
            Console.ResetColor();
            for (int z = 0; z < array.GetLength(1) - 1; z++)
            {
                if (array[i, z] < array[i, z + 1])
                {
                    int temp = 0;
                    temp = array[i, z];
                    array[i, z] = array[i, z + 1];
                    array[i, z + 1] = temp;
                }
            }
            for (int y = 0; y < array.GetLength(0); y++)
            {
                for (int f = 0; f < array.GetLength(1); f++)
                {
                    Console.Write($"{array[y, f]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}

Console.WriteLine("Geben Sie die Anzahl der Zeilen ein: ");
int zeile = int.Parse(Console.ReadLine()!);
Console.WriteLine("Geben Sie die Anzahl der Spalten ein: ");
int spalte = int.Parse(Console.ReadLine()!);

int[,] neuArray = ArrayErstellen(zeile, spalte);
Console.WriteLine("Массив до сортировки.");
PrintArray(neuArray);
Console.WriteLine();
Console.WriteLine("Массив после сортировки.");
Metod(neuArray);

