// задача 44. не используя рекурсию, выведите первые n-чисел Фибоначе
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
string FibNum(int num)
{
  string res = "0 1";
  int first = 0;
  int last = 1;
  int buf = 0;
  for (int i = 2; i < num; i++)
  {
    res = res + " " + (first + last).ToString();// превращаем число в строку и накапливаем
    buf = last;
    last = last + first;
    first = buf;
    //(first,last)=(last,first+last);
  }
  return res;
}
int num = ReadData("Введите количество элементов числа Фибоначче: ");
PrintData($"Число Фибоначче для {num} количества элементов равно: {FibNum(num)}");