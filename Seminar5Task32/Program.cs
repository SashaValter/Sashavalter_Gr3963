// задача 32. напишите программу замены элементов массива
// положительные элементы заменить на соответствующие отрицательные и наоборот
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
void inverseArr(int[] arr)// данный метод использует ссылочный тип данный
{
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = arr[i] * (-1);// меняем знак элемента массива
  }
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Console.WriteLine("Первоначальный вариант массива:");
Print1DArr(arr1);
inverseArr(arr1);
Console.WriteLine("Преобразованный вариант массива:");
Print1DArr(arr1);