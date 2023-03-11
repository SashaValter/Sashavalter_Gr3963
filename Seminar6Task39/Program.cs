// задача 39. напишите программу, которая перевернет одномерный массив
// 1й элемент будет на последнем месте, последний на первом
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
void SwopArray(int[] arr)// метод который переворачивает массив
{
  int buffElem = 0;// заказываем буфферную переменную
  for (int i = 0; i < arr.Length / 2; i++)// arr.length/2 потому что мы меняем 2 элемента за один проход и не имееет смысла проходить весь массив
  {
    buffElem = arr[i];// выполняем классическую операцию свапа
    arr[i] = arr[arr.Length - 1 - i];// arr[arr.Length-1-i] здесь обращаемся к последнему элту массива, предпоследнему и тд
    arr[arr.Length - 1 - i] = buffElem;
    // свапать можно так: (arr[i], arr.Length-1-i) = (arr.Length-1-i, arr[i]);
  }
}
int[] SwapNewArr(int[] arr)// метод который на выходе дает новый массив
{
  int[] outArr = new int[arr.Length];// заказываем переменную в виде массива
  for (int i = 0; i < outArr.Length; i++)// проходимся по всему массиву
  {

  outArr[i] = arr[arr.Length-1-i];// кладем в значение первого элемента выходного массива значение массива который был на входе
  }
  return outArr;// возвращаем массив
}

int len = ReadData("Введите длину массива:");
int min = ReadData("Введите min :");
int max = ReadData("Введите max :");
int[] arr1 = Gen1DArr(len, min, max);
Console.WriteLine("первоначальный вариант массива: ");
Print1DArr(arr1);
int [] newArr = SwapNewArr(arr1);// используем метод, который на выходе выдает массив
Console.WriteLine("вариант массива после преобразования методом разворота: ");
Print1DArr(newArr);
