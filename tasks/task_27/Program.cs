//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int NumAbruf(int zahl)
{
    int sum = 0;

    if(zahl < 0)
    {
        zahl = zahl * -1;
    }

    while(zahl > 0)
    {
       sum = sum + zahl % 10;
       zahl = zahl / 10;
    }
    return sum;
}

Console.WriteLine("geben Sie eine Zahl ein: ");
int num = int.Parse(Console.ReadLine()!);

int res = NumAbruf(num);
Console.WriteLine($"summe der Zahlenziffern: {res}");