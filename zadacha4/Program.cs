//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a;
int b;
int c;

Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
Console.Write("max = ");
Console.Write(max);
