// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
// Если 1 число не кратно числу 2, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int m = Convert.ToInt32(Console.ReadLine());

if (n%m==0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("Не кратно, остаток " + n%m);
}
