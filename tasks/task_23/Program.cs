//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

void CountIt(int num)
{
    Console.WriteLine("Число\tКуб");
    for(int i = 1; i <= num; i++)
    {
        int res = i * i * i;
        Console.WriteLine("число {0}\t{1}", i, res);
    }
}
Console.WriteLine("Введите количество чисел, которое необходимо возвести в третью степень: ");
int number = int.Parse(Console.ReadLine()!);
CountIt(number);
