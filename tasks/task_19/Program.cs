//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void PrintRes(int num, bool value)
{
    if(value)
    {
        Console.WriteLine($"Число {num} является полиндромом.");
    }
    else Console.WriteLine($"Число {num} не полиндром.");
}

void Polindrom(int num)
{
    int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, res = 0;
    bool value;

    if(num < 10000 || num > 99999)
    {
        Console.WriteLine("Ошибка! Введено неверное число.");
    }
    else
    {
        a1 = num / 10000;
        a2 = (num / 1000) % 10;
        a3 = (num / 100) % 10;
        a4 = (num / 10) % 10;
        a5 = num % 10;

        if(a1 == a5 && a2 == a4)
        {
            res = a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
            value = true; 
            PrintRes(num, value);
        }
        else
        {
            value = false;
            PrintRes(num, value);
        }
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

Polindrom(number);
