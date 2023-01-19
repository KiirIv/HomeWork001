/* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("введите число");
string numberStr = Console.ReadLine();
int a = Convert.ToInt32(numberStr);

if (a / 2)
{ 
    Console.WriteLine("число чётное");
     }
else 
{ 
    Console.WriteLine("число нечётное"); 
    }