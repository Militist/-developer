//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int Degree(int num, int degree)
// {
//     int mult = 1;
//     for(int i = 0; i < degree; i++)
//     {
//         mult = mult * num;
//     }
//     return mult;
// }

int Degree1(int num, int degree)
{
    int count = 1;
    int mult = 1;
    while(count <= degree)
    {
        mult *= num;
        count++;
    }
    return mult;
}

System.Console.WriteLine("Введите число, которое необходимо возвестив степень: ");
int num = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите степень: ");
int deg = int.Parse(Console.ReadLine()!);

int res = Degree1(num, deg);
Console.WriteLine($"Возводимое число: {num}, степень: {deg}, результат возведения: {res}");