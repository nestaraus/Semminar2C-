// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12 -> 2
// 85 -> 8

Console.Clear();
int n = new Random().Next(10,100);
Console.WriteLine("Рандомное число:"+n);
int n1 = n/10;
int n2 = n%10;
if (n1 > n2)
{
    Console.WriteLine(n1);
}
else
{
    Console.WriteLine(n2);
}