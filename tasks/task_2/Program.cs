// Задача №4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 3-ое число: ");
int c = int.Parse(Console.ReadLine()!);

if(a > b && a > c)
{
    Console.WriteLine($"Наибольлшее число - это {a}");
}
else if(b > a && b > c)
{
    Console.WriteLine($"Наибольлшее число - это {b}");
}
else Console.WriteLine($"Наибольлшее число - это {c}");