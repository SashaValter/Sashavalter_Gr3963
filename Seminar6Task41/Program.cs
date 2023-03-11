// задача 41. пользователь вводит с клавиатуры m-чисел
// затем посчитайте сколько чисел больше нуля
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
int CountNum(int numM)
{
  int res = 0;
  for (int i = 0; i < numM; i++)
    if (ReadData("") > 0)
    {
      res++;
    }
  return res;
}
int numM = ReadData("Введите числа:");
PrintData($"Введенных чисел больше нуля - {CountNum(numM)}");