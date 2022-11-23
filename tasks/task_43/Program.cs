/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем*/

double[] SchaffungArrayKoordinaten()
{
    double[] array1 = new double[4];
    string[] array2 = {"b1", "k1", "b2", "k2"};

    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write($"Введите координаты {array2[i]}: ");
        array1[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return array1;
}

void Kreuzung(double[] array)
{
   double b1 = array[0];
   double k1 = array[1];
   double b2 = array[2];
   double k2 = array[3];

    if((k1 * b2 - k2 * b1) == 0)
    {
        Console.WriteLine("Прямые параллельны!");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые совпадают!");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        x = Math.Round(x, 3);
        y = Math.Round(y, 3);
        Console.WriteLine($"Персечение в точке: ({x};{y})");
    }
}

double[] neuArray = SchaffungArrayKoordinaten();
Kreuzung(neuArray);