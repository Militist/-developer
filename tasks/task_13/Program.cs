//Задача №13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, 
//что третьей цифры нет.
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int count = 0, a3 = 0, num = 0;
a3 = (a / 100) % 10;
while(a > 0)
{
    num = a % 10;
    a = a / 10;
    count++;
}
if(count < 3)
{
    System.Console.WriteLine("Третьей цифры не существует.");
}
else
{
    System.Console.WriteLine($"Третья цифра введённого числа - это {a3}");
}
