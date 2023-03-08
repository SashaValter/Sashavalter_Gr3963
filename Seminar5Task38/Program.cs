// задача 38. задайте массив дробных чисел
// найдите разницу между максимальным и минимальным элементом массива
void PrintData(string msg)// используем метод вывода результата
{
  Console.WriteLine(msg);
}
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void Print1DArr(double [] arr)
{
  Console.Write("[");
  for (int i = 0; i < arr.Length - 1; i++)
  {
    Console.Write(arr[i] + "\t");
  }
  Console.Write(arr[arr.Length - 1]);
  Console.WriteLine("]");
}
double [] Gen1DArr(int len, int min, int max)//  универсальный метод
{
  // блок корректировки входных данных
  if (min > max)
  {
    int buf = min;
    max = min;
    max = buf;
  }
  Random rnd = new Random();// объявляем переменную, значение которой будет случайным при каждом запуске
  double[] arr = new double[len];// задаем массив, длина которого определяется выбранным значением
  for (int i = 0; i < arr.Length; i++)
    {
      arr[i] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 3);
    }
  return arr;
}
double MaxMin(double [] arr)
{
  double min = double.MaxValue;
  double max = double.MinValue;
  for (int i=0; i<arr.Length; i++)
  {
    if (arr[i]>max) max=arr[i];
    if (arr[i]<min) min = arr[i];
  }
  return (max-min);
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите минимально возможное значение для элементов массива :");
int max = ReadData("Введите максимально возможное значение для элементов массива :");
double[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
PrintData($"Разница между максимальным и минимальным значением массива равна: {MaxMin(arr1)}");