// задача 34 задайте массив заполненный случайными положительными
// трехзначными числами и напишите программу, которая посчитает
// количество четных чисел в массиве
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
int countEvenNum(int[] arr)
{
  int len = arr.Length;
  int count = 0;
  int[] buffArr = new int[len];
  for (int i = 0; i < len; i++)// пробегаемся по всем элементам массива
  {
    if (arr[i] % 2 == 0)// проверяем требуемое условие
    {
      count++;// считаем четные числа
    }
  }
  return count;
}
void PrintData(string msg)// используем метод вывода результата
{
  Console.WriteLine(msg);
}

int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
PrintData($"количество положительных чисел в массиве: {countEvenNum(arr1)}");