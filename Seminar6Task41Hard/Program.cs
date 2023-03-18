// задача 41. вариант решения со звездочкой
using System.Text.RegularExpressions; // вызываем в нашем коде регулярные выражения
int taps = ReadData("Введите количество нажатий");
string inputLine = ReadLineData("Введите любые символы с клавиатуры");
Console.WriteLine(inputLine);
FindNumbersInString(inputLine, taps);
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
string ReadLineData(string msg)// метод считывает нажатие клавиш на клавиатуре заданное количество раз
// и собирает данные
{
  Console.WriteLine(msg);
  string line = "";
  for (int i = 0; i < taps; i++)
  {
    var key = Console.ReadKey(true); // параметр true указан для того, чтобы после нажатия клавишь ничего не поменялось в конце
    line = line + string.Format(key.KeyChar.ToString()) + ",";
  }
  line = line.TrimEnd(',');
  return line;
}
void FindNumbersInString(string str, int count)
{
  Regex regex = new Regex(@"\d"); // задаем для поиска параметр "любая десятичная цифра"
  MatchCollection matches = regex.Matches(str);
  int posNums = 0;
  if (matches.Count > 0)// если  цифры найдены, то накапливаем результат, каждая найденная +1 к итогу
  {
    foreach (Match match in matches)
    {
      posNums++;
    }
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов найдено чисел: {posNums}");
  }
  else
  {
    Console.WriteLine($"Вы совершили нажатий: {count}. Среди введенных символов чисел не найдено");
  }
}
