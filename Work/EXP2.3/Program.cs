// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(day % 7);
if (day % 7 > 0 & day % 7 <= 5)

    Console.WriteLine("нет, будний день");
else
    Console.WriteLine("да, выходной день");

