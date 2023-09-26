// Напишите программу которая на вход принимает два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());

if (n * n==m)
{
    Console.WriteLine("yes");
}
else if (m * m == n)
{
    Console.WriteLine("yes");
}
else
{
     Console.WriteLine("no");
}