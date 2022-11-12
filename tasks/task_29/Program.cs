//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] ZeigArray()
{
    int[] MeinAarray = new int[8];
    Random rand = new Random();

    for(int i = 0; i < MeinAarray.Length; i++)
    {
        MeinAarray[i] = rand.Next(1, 100);
    }
    return MeinAarray;
}

int[] newMeinArray = ZeigArray();

Console.Write(String.Join(", ", newMeinArray));