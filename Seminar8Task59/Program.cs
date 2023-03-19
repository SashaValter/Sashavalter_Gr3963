// задача 59. задайте двумерный массив. напишите программу, которая удалит
// строчку и столбец, на пересечении которых расположен наименьший 
// элемент массива
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
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
int[,] Update2DArr(int[,] matr, int x, int y)
{
  int[,] resArr = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
  int k = 0;
  int m = 0;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    m = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if ((j != y) && (i != x))
      {
        resArr[k, m] = matr[i, j];
      }
      if (j != y) m++;
    }
    if (i != x) k++;
  }
  return resArr;
}
(int x, int y) MinElem2DArray(int[,] matr)
{
  int row = 0;
  int collumn = 0;
  int min = int.MaxValue;
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i, j] < min)
      {
        min = matr[i, j];
        row = i;
        collumn = j;
      }
    }
  }
  return (row, collumn);
}
int row = ReadData("Введите число строк");
int columns = ReadData("Введите число столбцов");
int min = ReadData("Введите минимально возможное значение элемента двумерного массива");
int max = ReadData("Введите максимально возможное значение элемента двумерного массива");
int[,] matrix = Gen2DArr(row, columns, min, max);
Console.WriteLine("матрица:");
Print2dArray(matrix);
(int x, int y) minElem = MinElem2DArray(matrix);
Console.WriteLine("Преобразованная матрица:");
int [,] out2DArr = Update2DArr(matrix, minElem.x, minElem.y);
Print2dArray(out2DArr);