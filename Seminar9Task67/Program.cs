// задача 67. напишите программу, которая принимает на вход число
// и возвращает сумму цифр этого числа при помощи рекурсии
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
int RecSumDig(int num)
{
  if (num == 0)
  {
    return 0;
  }
  else
  {
    return num % 10 + RecSumDig(num / 10);
  }
}
int num = ReadData("Введите число");
PrintData($"Сумма цифр в числе равна - {RecSumDig(num)}");