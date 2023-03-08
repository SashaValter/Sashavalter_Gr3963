// задача 36. выведите одномерный массив, заполненный случайными числами
// найдите сумму элементов, стоящих на нечетной позиции
void PrintData(string msg)// используем метод вывода результата
{
  Console.WriteLine(msg);
}
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
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
int[] Gen1DArr(int len, int min, int max)//  универсальный метод
{
  // блок корректировки входных данных
  if (min > max)
  {
    int buf = min;
    max = min;
    max = buf;
  }
  Random rnd = new Random();// объявляем переменную, значение которой будет случайным при каждом запуске
  int[] arr = new int[len];// задаем массив, длина которого определяется выбранным значением
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);//значения в массиве будут генерироваться в выбранном нами интервале
  }
  return arr;
}
int sumOddNum(int[] arr)
{
  int len = arr.Length;
  int count = 0;
  int[] buffArr = new int[len];
  for (int i = 0; i < len; i += 2)// пробегаемся по всем элементам массива
  {
    count = count + arr[i];
  }
  return count;
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
PrintData($"сумму элементов, стоящих на нечетной позиции равна:{sumOddNum(arr1)} ");