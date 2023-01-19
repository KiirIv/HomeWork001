/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("введите первое число");
string numberStr1 = Console.ReadLine();
int a = Convert.ToInt32(numberStr1);

Console.WriteLine("введите второе число");
string numberStr2 = Console.ReadLine();
int b = Convert.ToInt32(numberStr2);

Console.WriteLine("введите третье число");
string numberStr3 = Console.ReadLine();
int c = Convert.ToInt32(numberStr3);
int max = 0;

if (a > b)
{ max = a; }
if (a > c)
{ max = a; }
else if (c > b)
{ max = c; }
else
{ max = b; }

Console.WriteLine(max);