/*Задача №50. Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, 
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] ArrayErstellen(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random(); 
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10, 100); 
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

void FindeDasElement(int[,] array, int zahl)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == zahl)
            {
                Console.WriteLine($"Введенное число {zahl} обнаружено на позиции {i}, {j}");
                return;
            }
        }
    }
    Console.Write("Такого числа не обнаружено.");
}

System.Console.WriteLine("Geben Sie die Anzahl der Zeilen ein: ");
int zeile = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Geben Sie die Anzahl der Spalten ein: ");
int spalte = int.Parse(Console.ReadLine()!);

int[,] neuArray = ArrayErstellen(zeile, spalte);
AusdruckenArray(neuArray);

System.Console.WriteLine("Введите искомое число: ");
int neuZahle = int.Parse(Console.ReadLine()!);

FindeDasElement(neuArray, neuZahle);
