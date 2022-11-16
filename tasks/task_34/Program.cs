
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetArray()
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PositivNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"количество чётных чисел в массиве: {count}");
}

int[] MyArray = GetArray();
Console.WriteLine(String.Join(", ", MyArray));
PositivNum(MyArray);