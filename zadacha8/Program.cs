//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int N;
Console.WriteLine("Введите N");
N = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index < N)
{
Console.WriteLine(index+1);
index += 2;
}