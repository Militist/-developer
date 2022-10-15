// Задача №8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите любое целое число: ");
int N = int.Parse(Console.ReadLine()!);

// for(int i = 1; i < N; i++)
// {
//     if(i % 2 != 0) 
//     {
//         continue;
//     }
//     System.Console.WriteLine($"Чётное число из заданного промежутка: {i}");
// }

int i = 1;
while(i < N)
{
    if(i % 2 == 0)
    {
        System.Console.WriteLine($"Чётное число из заданного промежутка: {i}");
    }
    i++;
}