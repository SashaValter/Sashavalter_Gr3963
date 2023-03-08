// задача 31. задайте массив из 12 элементов заполненный случайными числами
// в промежутке от -9 до 9
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
void PrintData(string msg, int res)
{
  Console.WriteLine(msg + res);
}
(int positive, int negative) NegPosSum(int[] arr)// метод для вывода двух результатов, принимает на вход массив
{
  int posSum = 0;// вводим переменную для суммы положительных
  int negSum = 0;//вводим переменную для суммы отрицательных
  
  for (int i = 0; i < arr.Length; i++)// пробегаемся по всему массиву
  {
    if (arr[i] > 0)//задаем условие 
    {
      posSum += arr[i];// в этой строчке будет сумма всех положительных
    }
    else
    {
      negSum += arr[i];// в этой строчке будет сумма всех отрицательных
    }
  }
  return (posSum, negSum);
}
int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Print1DArr(arr1);
(int posit, int negot) results = NegPosSum(arr1);
PrintData("сумма положительных чисел в массиве: ", results.posit);
PrintData("сумма отрицательных чисел в массиве: ", results.negot);
// в 62 и 63 строке после точки мы обращаемся к одному из двух результатов
// после запуска метода и подсчета
// наш метод считает два результата и данным действием мы можем обратиться к одному из них