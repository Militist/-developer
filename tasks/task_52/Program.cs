/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] ArrayErstellen(int m, int n)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void AusdruckenArray(int[,] array)
{
    Console.WriteLine("Полученный массив случайных чисел.");
    Console.WriteLine("------------------------------------");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void SummeDerElemente(int[,] array, double num)
{
    double sum = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            sum = Convert.ToDouble(sum + array[i, j]);
        }
        sum = sum / num;
        Console.WriteLine("Среднеарифметическое значение {0,6:F1} \t", sum);
    }
}

Console.WriteLine("Geben Sie die Anzahl der Zeilen ein: ");
int zeile = int.Parse(Console.ReadLine()!);
Console.WriteLine("Geben Sie die Anzahl der Spalten ein: ");
int spalte = int.Parse(Console.ReadLine()!);

