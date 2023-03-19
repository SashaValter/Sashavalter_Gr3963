// cформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Принимаем из консоли число
int ReadInputInt(string mess)
{
  Console.Write(mess);
  return Convert.ToInt32(Console.ReadLine() ?? "0");
}

//Генерируем массив случайными уникальными числами
int[,,] Gen3DArrRandomUnique(int row, int colum, int list, int bottom, int top)
{
  Random rnd = new Random();
  int[,,] arr = new int[row, colum, list];

  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < colum; j++)
    {
      for (int k = 0; k < list; k++)
      {
        while (true)
        {
          int num = rnd.Next(bottom, top);
          if (CheckNumberIn3DArray(arr, num) == false)
          {
            arr[i, j, k] = num;
            break;
          }
        }
      }
    }
  }

  return arr;
}

// выводим двумерный массив на экран 
void Print3DArr(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.Write($"{arr[i, j, k]} ({i}, {j}, {k})\t");
        Console.Write(arr[i, j, k] + " (" + i + ", " + j + ", " + k + ")\t");
        Console.Write("{0} ({1}, {2}, {3})\t", arr[i, j, k], i, j, k);
      }
      Console.WriteLine();
    }
  }
}

bool CheckNumberIn3DArray(int[,,] arr, int numer)
{
  // перебираем элементы массива
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        if (arr[i, j, k] == numer) // если элемент равен нужному числу
        {
          return true; // выходим из метода, т.к. дальнейший поиск не имеет смысла
        }
      }
    }
  }

  // если дошли до этой строки, значит число не было найдено
  return false;
}

int countRow = ReadInputInt("Введите количество строк для трехмерного массива: ");
int countColum = ReadInputInt("Введите количество столбцов для трехмерного массива: ");
int countList = ReadInputInt("Введите количество листов для трехмерного массива: ");

int min = 10;
int max = 100;

int[,,] mas = Gen3DArrRandomUnique(countRow, countColum, countList, min, max);

Console.WriteLine("Массив:");
Print3DArr(mas);