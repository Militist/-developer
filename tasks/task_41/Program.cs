//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int[] GetArray()
{
   Console.Write("Введите необходимую длину массива: ");
   int wert = int.Parse(Console.ReadLine()!);

   int[] MeinArray = new int[wert];

   for(int i = 0; i < MeinArray.Length; i++)
   {
        Console.Write($"Введите число под индексом {i + 1}: ");
        MeinArray[i] = int.Parse(Console.ReadLine()!);
   }
   Arraydrucken(MeinArray);
   return MeinArray;
}

void Arraydrucken(int[] array)
{
    Console.WriteLine(String.Join(", ", array));
}

int ZahlenSuchen(int[] array)
{
    int zaehler = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            zaehler++;
        }
    }
    return zaehler;
}

int[] NeuArray = GetArray();
int res = ZahlenSuchen(NeuArray);
Console.WriteLine($"Количество введённых положительных чисел: {res}");
