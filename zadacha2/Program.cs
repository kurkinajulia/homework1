//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int a;
int b;
Console.WriteLine("Введите a");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
b = Convert.ToInt32(Console.ReadLine());
int max = a;
int min = a;
if (a>max)
{
max = a;
min = b;
}
if (b>max)
{
max = b;
min = a;
}
Console.WriteLine("max = ");
Console.WriteLine(max);
Console.WriteLine("min = ");
Console.WriteLine(min);