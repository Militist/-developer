//Метод, задающий длину массива и заполняющий его.
double[] GetArray()
{
    Console.Write("Укажите длину массива:\t");
    int elementsCount = int.Parse(Console.ReadLine()!);

    double[] myArray = new double[elementsCount];

    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"Введите случайный элемент массива вещественных чисел под индексом {i + 1}:\t ");
        myArray[i] = double.Parse(Console.ReadLine()!);
    }
    PrintArray(myArray);
    return myArray;
}

void PrintArray(double[] array)
{
    Console.WriteLine("Массив, заполненный случайными вещественными числами:");
    Console.WriteLine(String.Join(", ", array));
}
//Метод, ведущий поиск максимального и минимального элементов массива и возвращающий их разницу.
double UnterElement(double[] array)
{
    double maxValue = array[0];
    double minValue = array[0];

    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minValue)
        {
            minValue = array[i];
        }
        if(array[i] > maxValue)
        {
            maxValue = array[i];
        }
    }
    PrintElemet(maxValue, minValue);
    return maxValue - minValue;
}

void PrintElemet(double maxValue, double minValue)
{
    Console.WriteLine($"Получены наименьший - {minValue} и наибольший - {maxValue} эелементы массива.");
}

double res = UnterElement(GetArray());
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {res}");
/*Вариант заполнения массива случайными вещественными числами
void GetArray()
{
    int size = 3;
    double[] myArray = new double[size];
    for(int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    System.Console.WriteLine(String.Join(", ", myArray));
}
GetArray();*/
