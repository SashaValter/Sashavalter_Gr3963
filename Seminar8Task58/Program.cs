// задача 58. задайте два двумерных массива,перемножьте их
// выведите результирующую матрицу на экран
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
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
static int[,] Multiplication(int[,] a, int[,] b)
{
  if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
  int[,] r = new int[a.GetLength(0), b.GetLength(1)];
  Parallel.For(0, a.GetLength(0), (i) =>
  {
    for (int j = 0; j < b.GetLength(1); j++)
    {
      for (int k = 0; k < b.GetLength(0); k++)
      {
        r[i, j] += a[i, k] * b[k, j];
      }
    }
  });
  return r;
}
int row1 = ReadData("Введите число строк первой матрицы");
int columns1 = ReadData("Введите число столбцов первой матрицы");
int row2 = ReadData("Введите число строк второй матрицы");
int columns2 = ReadData("Введите число столбцов второй матрицы");
int[,] matrix1 = Gen2DArr(row1, columns1, 0, 30);
Console.WriteLine("первая матрица:");
Print2dArray(matrix1);
int[,] matrix2 = Gen2DArr(row2, columns2, 0, 30);
Console.WriteLine("вторая матрица:");
Print2dArray(matrix2);
int[,] matrix3 = Multiplication(matrix1, matrix2);
Console.WriteLine("матрица, полученная в результате умножения:");
Print2dArray(matrix3);