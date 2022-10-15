//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите 1-ое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите 2-ое число: ");
int b = int.Parse(Console.ReadLine()!);
if(a > b)
{
    System.Console.WriteLine($"Наибольшее число - это {a}");
}
if(b > a)
{
    System.Console.WriteLine($"Наибольшее число - это {b}");
}
else System.Console.WriteLine("Введёные числа равны.");
