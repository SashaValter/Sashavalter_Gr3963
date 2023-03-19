//задача 53. задать двумерный массив и задать программу
// которая поменяет первую и последнюю строку массива
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
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

void SwapRowMethod(int[,] matr)
{
  int temp = 0;
  for (int i = 0; i < matr.GetLength(1); i++)
  {
    temp = matr[0,i];
    matr[0,i] = matr[matr.GetLength(0)-1,i];
    matr[matr.GetLength(0)-1,i] = temp;
    // (matr[0,i],matr[matr.GetLength(0)-1,i])=(matr[matr.GetLength(0)-1,i], matr[0,i]);
  }
}

int row = ReadData("Введите число строк");
int columns = ReadData("Введите число столбцов");
int min = ReadData("Введите минимально возможное значение элемента двумерного массива");
int max = ReadData("Введите максимально возможное значение элемента двумерного массива");
int[,] matrix = Gen2DArr(row, columns, min, max);
Console.WriteLine("Первоначальная матрица:");
Print2dArray(matrix);
SwapRowMethod(matrix);
Console.WriteLine("Преобразованная матрица:");
Print2dArray(matrix);