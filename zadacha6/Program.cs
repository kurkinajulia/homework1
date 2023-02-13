//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

int N;
Console.WriteLine("Введите N");
N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
Console.WriteLine("да");
if (N % 2 != 0)
Console.WriteLine("нет");