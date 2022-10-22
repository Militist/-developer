//Метод, осуществляющаяя ввод координат, начиная с точки А и показывает их.
void FillArray(double[] arrayA, double[] arrayB)
{
    string str = "";
    for(int i = 0; i < arrayA.Length; i++)
    {
        Console.Write($"Введите координату точки A с индексом {i}:\t ");
        arrayA[i] = int.Parse(Console.ReadLine()!);
    }

    for(int i = 0; i < arrayA.Length; i++)
    {
        str = string.Join(", ", arrayA);
    }
    Console.WriteLine("Введённые координаты точки A: " + str);

    for(int i = 0; i < arrayB.Length; i++)
    {
        Console.Write($"Введите координату точки B с индексом {i}:\t ");
        arrayB[i] = int.Parse(Console.ReadLine()!);
    }

    for(int i = 0; i < arrayB.Length; i++)
    {
        str = string.Join(", ", arrayB);
    }
    Console.WriteLine("Введённые координаты точки B: " + str);
}

////Функция, осуществляющаяя ввод координат, начиная с точки В и показывает их.
void FillArray1(double[] arrayA, double[] arrayB)
{
    string str = "";
    for(int i = 0; i < arrayB.Length; i++)
    {
        Console.Write($"Введите координату точки B с индексом {i}:\t ");
        arrayB[i] = int.Parse(Console.ReadLine()!);
    }

    for(int i = 0; i < arrayB.Length; i++)
    {
        str = string.Join(", ", arrayB);
    }
    Console.WriteLine("Введённые координаты точки B: " + str);

    for(int i = 0; i < arrayA.Length; i++)
    {
        Console.Write($"Введите координату точки A с индексом {i}:\t ");
        arrayA[i] = int.Parse(Console.ReadLine()!);
    }

    for(int i = 0; i < arrayA.Length; i++)
    {
        str = string.Join(", ", arrayA);
    }
    Console.WriteLine("Введённые координаты точки A: " + str);
}
//Метод, осуществляющий выбор точки, с которой начинается ввод.
void ArraySelection(double[] arrayA, double[] arrayB)
{
    Console.WriteLine("Укажите точку, координаты которой хотите вести: ");
    string name = Console.ReadLine()!;
    for(int i = 0; i < name.Length; i++)
    {
        if(char.IsLower(name[0]))
        {
            System.Console.WriteLine("Внимание! Ввод осуществляется со строчной буквы.");
        }
        Console.WriteLine("Повторите ввод.");
    }
    if(name == "A")
    {
        FillArray(arrayA, arrayB);
    }
    else if(name == "B")
    {
        FillArray1(arrayA, arrayB);
    }
    GetLine(arrayA, arrayB);
}
//Метод расчёта длины прямой.
void GetLine(double[] arrayA, double[] arrayB)
{
    double res1 = (arrayB[0] - arrayA[0]) * (arrayB[0] - arrayA[0]);
    double res2 = (arrayB[1] - arrayA[1]) * (arrayB[1] - arrayA[1]);
    double res3 = (arrayB[2] - arrayA[2]) * (arrayB[2] - arrayA[2]);
    double res = Math.Sqrt(res1 + res2 + res3);
    Console.WriteLine("Таблица результатов.");
    Console.WriteLine("--------------------");
    Console.WriteLine("{0:N2}", res);
}


double[] arrayCoorA = new double[3];
double[] arrayCoorB = new double[3];
ArraySelection(arrayCoorB, arrayCoorA);
Console.WriteLine();
ArraySelection(arrayCoorB, arrayCoorA);
