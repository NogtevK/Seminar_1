﻿/* 5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2" */

/* int N = 4;
int A = -N;
while (A<=N)
{
    Console.WriteLine("A "+A);
    A++;
}
 */


/* 7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8 */

int n=123;

if (n > 99 & n < 1000)
{
    Console.WriteLine(n);
    Console.WriteLine(n % 10);
}
else
{
    Console.WriteLine("Неправильно!");
}