//Задача №15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5) 
{
    Console.WriteLine("Это рабочий день.");
}
else if(day == 6 || day == 7) 
{
    Console.WriteLine("Это выходной день.");
}
else Console.WriteLine("Ошибка. Дня недели с введённым номером не сществует.");