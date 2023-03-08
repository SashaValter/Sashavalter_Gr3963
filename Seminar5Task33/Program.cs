// задача 33. задайте массив и напишите программу, которая определяет
// присутствует ли заданное число в массиве
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
bool searchEl(int[] arr, int elem)// данный метод использует ссылочный тип данный
// bool тип данных либо true либо false
{
  bool res = false;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == elem)
    {
      res = true;
      Console.WriteLine($"число {elem} присутствует в массиве c индексом {res}");
      break;// данная операция позволяет прервать цикл если хотя бы один искомый элемент содержится в массиве
    }
    else
    {
      Console.WriteLine($"числа {elem} нет в данном массиве");
      break;
    }
  }
  return res;
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
int num = ReadData("Введите искомое число: ");
searchEl(arr1, num);