// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int n1 = new Random().Next(1,10);
int n2 = new Random().Next(1,10);
int n3 = new Random().Next(1,10);

int[] array = { n1, n2, n3};

Console.Write(n1);
Console.Write(n2);
Console.Write(n3);

Console.WriteLine("");

Console.Write(array[0]);
Console.Write(array[2]);