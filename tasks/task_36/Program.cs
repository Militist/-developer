//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray()
{
    int[] array = new int[10];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void FillArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        {
            sum += array[i];
            Console.WriteLine($"число {array[i]} на нечётной позиции: {i + 1}");
        }
        // Console.WriteLine($"числа на нечётных позициях: {array[i]}");
    }
    Console.WriteLine($"сумма элементов на нечётных позициях равна: {sum}");
}

int[] MyAarray = GetArray();
System.Console.WriteLine(String.Join(", ", MyAarray));
FillArray(MyAarray);
