// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// 1.Считать от пользователя N
// 2.Cоздать массив
// 3.Метод получения кубов
// 4.Распечатать результат
// 5.Распечатать красиво


//
// 1.Считать от пользователя N
int GetNumberByUser(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

//2.Создать массив
int[] GetArray(int size)
{
  return new int[size+1];
}

//3.Получение кубов чисел

void GetCub(int[] colNum)
{
  int count = colNum.Length;
  for (int i = 1; i < count; i++)
  {
    colNum[i] =Convert.ToInt32(Math.Pow(i,3));
  }
}

// 4.Распечатать результат
string Print(int[] num)

{
  string output = String.Empty;
  int size = num.Length;
  for (int i = 1; i < size; i++)
  {
    output = output + $"- {i}^3 ={ num[i]}\n";
  }
  return output;
}

 int CountByUser= GetNumberByUser("Введите число: ");
 int[]list = GetArray(CountByUser);
 GetCub(list);
 string result= Print(list);
 Console.WriteLine(result);