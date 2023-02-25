// Задача 23. Напишите программу, которая принимает на вход число n
// и выдает таблицу кубов чисел от 1 до n
// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// напишем метод для построения таблицы из кубов чисел LineBuilder
//например n=5
//1 2 3 4 5
//1 8 27 64 125
string LineBuilder(int num, int pow)
{
  string res = string.Empty;
  for (int i = 1; i <= num; i++)
  {
    res = res + Math.Pow(i, pow) + "\t";// накапливаем числа для первой строки без квадратов
  }
  return res;
}

// просим ввести число num
int num = ReadData("Введите конечное число: ");
//выводим строку с 1 степенью и со степенью 2
Console.WriteLine(LineBuilder(num, 1));
Console.WriteLine(LineBuilder(num, 3));