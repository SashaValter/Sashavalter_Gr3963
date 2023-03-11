// задача 45. напишите программу, которая будет создавать копию заданного 
//одномерного массива с помощью поэлементного копирования
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
int[] Gen1DArr(int len, int min, int max)//  универсальный метод
{
  // блок корректировки входных данных
  if (min > max)
  {
    (max,min)=(min,max);
    // int buf = min;
    // max = min;
    // max = buf;
  }
  Random rnd = new Random();// объявляем переменную, значение которой будет случайным при каждом запуске
  int[] arr = new int[len];// задаем массив, длина которого определяется выбранным значением
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);//значения в массиве будут генерироваться в выбранном нами интервале
  }
  return arr;
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
int [] CopyArrayStandartTool (int [] inputArr)
{
  int [] outArr = new int[inputArr.Length];
  inputArr.CopyTo(outArr,0);// обращаемся к встроенному методу копирования
  // здесь выбираем куда копировать и через запятую с какого элемента копируем
  return outArr;
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Console.WriteLine("Первоначальный вариант массива");
Print1DArr(arr1);
int[] arr2 = (int[])CopyArrayStandartTool(arr1);
Console.WriteLine("Скопированный вариант массива");
Print1DArr(arr2);