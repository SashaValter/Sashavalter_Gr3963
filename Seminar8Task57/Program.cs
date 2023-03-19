// задача 57. составить частотный словарь элементов двумерного массива
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
void Print1DArr(int[] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + ",");
  }
  Console.Write(arr[arr.Length - 1]);
  Console.WriteLine("]");
}
void Print2dArray(int[,] matr)// метод печати двумерного массива
{
  ConsoleColor[] col = new ConsoleColor[] { ConsoleColor.Black, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.DarkBlue, ConsoleColor.Green, ConsoleColor.DarkRed, ConsoleColor.White, ConsoleColor.Magenta };
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.ForegroundColor = col[new Random().Next(0, 9)];// обращаемся к массиву цветов для окраски шрифта
      Console.Write($"{matr[i, j]}\t");
      Console.ResetColor();
    }
    Console.WriteLine();
  }
}
int[,] Gen2DArr(int countRow, int countColumn, int min, int max)//  универсальный метод
{
  // блок корректировки входных данных
  if (min > max)
  {
    (max, min) = (min, max);
    // int buf = min;
    // max = min;
    // max = buf;
  }
  Random rnd = new Random();// объявляем переменную, значение которой будет случайным при каждом запуске
  int[,] arr = new int[countRow, countColumn];// задаем массив, длина которого определяется выбранным значением
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = rnd.Next(min, max + 1);//значения в массиве будут генерироваться в выбранном нами интервале
    }
  }
  return arr;
}
//  в частотном словаре всего 4 позиции
int[] FreqDicBuild(int[,] arr, int len)
{
  int[] dic = new int[len];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      dic[arr[i, j]]++;
    }
  }
  return dic;
}
int row = ReadData("Введите число строк");
int columns = ReadData("Введите число столбцов");
int min = ReadData("Введите минимально возможное значение элемента двумерного массива");
int max = ReadData("Введите максимально возможное значение элемента двумерного массива");
int[,] matrix = Gen2DArr(row, columns, min, max);
Console.WriteLine("матрица:");
Print2dArray(matrix);
Console.WriteLine("частотный словарь:");
Print1DArr(FreqDicBuild(matrix, 10));