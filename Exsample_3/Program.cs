// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Задача, выполненная по тз:

// Console.WriteLine ("Введите цифру дня недели" + " ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number <= 7)
// if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
// {
//     Console.WriteLine ("Не является выходным");
// }
// else
// {
//     Console.WriteLine ("Является выходным");
// }
// else
// {
//     Console.WriteLine ("Такого дня недели нет");
// }

// Задача с указанием дней недели:

Console.WriteLine ("Введите цифру дня недели" + " ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number <= 7)
if (number == 1 || number == 2 || number == 3 || number == 4 || number == 5)
{
    if (number == 1)
    Console.WriteLine ("Понедельник не является выходным");
    if (number == 2)
    Console.WriteLine ("Вторник не является выходным");
    if (number == 3)
    Console.WriteLine ("Среда не является выходным");
    if (number == 4)
    Console.WriteLine ("Четверг не является выходным");
    if (number == 5)
    Console.WriteLine ("Пятница не является выходным, но уже приятнее :)");
}
else
{
   if (number == 6)
    Console.WriteLine ("Суббота является выходным");
    if (number == 7)
    Console.WriteLine ("Воскресенье является выходным");
}
else
{
    Console.WriteLine ("Такого дня недели нет");
}
