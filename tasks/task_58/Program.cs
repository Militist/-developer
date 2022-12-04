/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int[,] ArrayErstellen(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
void Matrica()
{
    Console.Write("Укажите размер матрицы: ");
    int umfang = int.Parse(Console.ReadLine()!);

    int[,] arrayA = new int[umfang, umfang];
    int[,] matrixA = ArrayErstellen(arrayA);
    Console.WriteLine("Матрица - А");
    PrintArray(matrixA);

    int[,] arrayB = new int[umfang, umfang];
    int[,] matrixB = ArrayErstellen(arrayB);
    Console.WriteLine("Матрица - B");
    PrintArray(matrixB);

    int[,] matrixC = new int[umfang, umfang];

    for (int i = 0; i < umfang; i++)
    {
        for (int j = 0; j < umfang; j++)
        {
            for (int k = 0; k < umfang; k++)
            {
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
            }
        }
    }
    Console.WriteLine("Матрица - С");
    PrintArray(matrixC);
}

Matrica();
