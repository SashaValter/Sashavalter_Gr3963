// задача 48. задайте двумерный массив, размер mxn, 
// каждый элемент массива находится по формуле A(m,n) = m+n
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
int[,] Gen2DArrMod(int countRow, int countColumn)// метод для генерации матрицы, элементы которой являются суммой строки и столбца для соответствующего элемента
{
  int[,] arr = new int[countRow, countColumn];// задаем массив, длина которого определяется выбранным значением
  for (int i = 0; i < countRow; i++)
  {
    for (int j = 0; j < countColumn; j++)
    {
      arr[i, j] = i + j;//значения в матрице будут складываться из суммы номера строки и столбца для соответствующего элемента
    }
  }
    return arr;
}
int row = ReadData("Введите число строк");
int columns = ReadData("Введите число столбцов");
int[,] matrix = Gen2DArrMod(row,columns);
Console.WriteLine("Двумерный массив:");
Print2dArray(matrix);