20 lines (17 sloc)  594 Bytes

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine ("Введите число" + " ");
string answer = Console.ReadLine ();
int number = Convert.ToInt32 (answer);
if (number >= 100 && number < 1000)
{
    int resalt = number / 10;
int resalt1 = resalt % 10;
Console.Write (resalt1);
}
else 
{
    Console.Write ("Число не трехзначное");
}
