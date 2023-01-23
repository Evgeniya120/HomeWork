// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ


bool Polindrom(int number1)

{
    int number2 = 0;
    int x = number1;
    while (number1 > 0)
    {
        int y = number1 % 10;
        number1 = number1 / 10;
        number2 = number2 * 10 + y;
    }
    return x == number2;
}
Console.WriteLine(Polindrom(23432));
