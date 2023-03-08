// задача 35. выведите массив из 123 случайных чисел. 
// найдите количество элементов массива, значение которых лежит в отрезке
// [10,99]
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
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
int numElemInRange (int [] arr, int minVal, int maxVal)
{
  int res=-1;
  for (int i=0; i<arr.Length; i++)
  {
    if(arr[i]>minVal&& arr[i]<maxVal)
    {
      res++;
    }
  }
  return (res==-1)?res:res+1;
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
numElemInRange(arr1, 99, 123);
PrintData($"число цифр в диапазоне: {numElemInRange(arr1, 99, 123)}");