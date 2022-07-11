/* 1. Напишите программу, которая на вход принимает два
числа и проверяет, является ли первое число квадратом
второго. 
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3 b = 9 -> нет*/
/* 
int a = 25;
int b = 5;

Console.WriteLine("Первое число: " + a);
Console.WriteLine("Второе число: " + b);
if(a == b*b)  
{
       Console.WriteLine("YES"); 
}
else
{
    Console.WriteLine("NO");
}
 */

/* 3. Напишите программу, которая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница */

Console.WriteLine("Введите число: ");
int number= int.Parse(Console.ReadLine());
if (number==1)
{
    Console.WriteLine("Понедельник");
}
if (number==2) 
{
    Console.WriteLine("Вторник");
}   
if (number==3)
{
    Console.WriteLine("Среда");
}
if (number==4)
{
    Console.WriteLine("Четверг");
}
if (number==5)
{
    Console.WriteLine("Пятница");
}
if (number==6)
{
    Console.WriteLine("Суббота");
}
if (number==7)
{
    Console.WriteLine("Восскресенье");
}
if (number>7)
{
    Console.WriteLine("7 дней в неделе");
}
if (number<1)
{
    Console.WriteLine("0 дней невозможно");
}
