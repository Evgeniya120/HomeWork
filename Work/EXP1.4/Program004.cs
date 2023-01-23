// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int[] array = { 1, 20, 3, 18, 5, 10, 43, 12 };
int N = array.Length;
int index = 0;

while (N > index)
{
    if (array[index] % 2 == 0)

        Console.WriteLine(array[index]);

    index++;
}
