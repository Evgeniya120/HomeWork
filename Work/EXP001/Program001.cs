// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int A = -9;
int B = -3;

int max;
int min;

if (A > B)
{
    max = A;
    min = B;
}

else
{
    max = B;
    min = A;
}

Console.WriteLine(max);
Console.WriteLine(min);