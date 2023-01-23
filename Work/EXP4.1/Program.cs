// Задача 777:

// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа
// [1,0,1,1,0,1,0,0]
// Реализовать перевод двоичного числа в десятичное

// 1. Ввод N
// int <- (string)

// 2. Создание массива
// int[] <- (int)

// 3. Заполнение массива 0 и 1
// void <- (int[])

// 4. Печать массива
// string <- (int[])

// 5. Конвертация из 2-ого в 10-ое
// int <- (int[])

// 6. 10110100 >> 180
// string <- (int[] , int)


// 1. Ввод N
int GetNumberByUser(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());

}

// 2. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}


// 3. Заполнение массива 0 и 1
void FillArray(int[] CreateArray)
{
    int count = CreateArray.Length;
    for (int i = 1; i < count; i++)
    {
        CreateArray[0] = 1;
        CreateArray[i] = new Random().Next(2);
    }
}

// 4. Печать массива
string PrintArray(int[] numbers)
{
    string output = String.Empty;
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        output += ($"{numbers[i]}\n");
    }
    return output;
}


// 5. Конвертация из 2-ого в 10-ое
int ConvertToDec(int[] arrBin)
{
    int count = arrBin.Length;
    int exponent = arrBin.Length - 1;
    int result = 0;

    for (int i = 0; i < arrBin.Length; i++)
    {
        if (arrBin[i] == 1)
        {
            result += Convert.ToInt32(Math.Pow(2, exponent));
        }
        exponent--;

    }
    return result;
}
string GoodPrint(int[] bin, int dec)
{
    return $"{String.Join("", bin)} >> {dec}";
}

int number = GetNumberByUser("Введите количество элементов массива: ");
int[] arr = CreateArray(number);
FillArray(arr);

int result = ConvertToDec(arr);
Console.WriteLine(result);
string binPrint = PrintArray(arr);
Console.WriteLine(binPrint);
Console.WriteLine(GoodPrint(arr, result));

