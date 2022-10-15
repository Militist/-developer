System.Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

if(a % 2 == 0)
{
    System.Console.WriteLine($"Да, число {a} делится без остатка.");
}
else System.Console.WriteLine($"Нет, число {a} является нечётным.");

