/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

/*Метод, заполняющий массив случйными вежественными чслами. 
Рассмотрен вариант с использованием встроенного метода NextDouble()*/
double[,] ArrayErstellen(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            // array[i, j] = random.NextDouble() * 100;
            array[i, j] = Convert.ToDouble(random.Next(-10, 50)) / 10;
        }
    }
    return array;
}

void AusdruckenArray(double[,] array)
{
    Console.WriteLine("Полученный массив вещественных чисел");
    Console.WriteLine("------------------------------------");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F1}", array[i, j]);
            // Console.WriteLine($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Geben Sie die Anzahl der Zeilen ein: ");
int zeile = int.Parse(Console.ReadLine()!);
Console.WriteLine("Geben Sie die Anzahl der Spalten ein: ");
int spalte = int.Parse(Console.ReadLine()!);

double[,] neuArray = ArrayErstellen(zeile, spalte);
AusdruckenArray(neuArray);