// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c;
        
        a = 2;
        b = 3;
        c = 7;
    
        
        int max = a;
        if (a > b)
        {
            a = max;
            if (a > c)
            {
                a = max;
            }
            else
            {
                c = max;
            }
        }
        else
        {
            b = max;
            if (b > c)
            {
                b = max;
            }
            else
            {
                c = max;
            }
        }

        Console.WriteLine(max);

