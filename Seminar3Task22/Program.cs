// Задача 22. Напишите программу, которая принимает на вход число n
// и выдает таблицу квадратов чисел от 1 до n
// метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// напишем метод для построения таблицы из квадратов чисел LineBuilder
//например n=5
//1 2 3 4 5
//1 4 9 16 25
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
int num = ReadData("Введите число num: ");
//выводим строку с 1 степенью и со степенью 2
Console.WriteLine(LineBuilder(num, 1));
Console.WriteLine(LineBuilder(num, 2));