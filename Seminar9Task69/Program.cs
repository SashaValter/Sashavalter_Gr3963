// задача 69. напишите программ, которая будет принимать 2 числа a и b
// и возведет a в степень b при помощи рекурсии
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
void PrintData(string msg)
{
  Console.WriteLine(msg);
}
long RecPow(int a, int b)
{
  if (b <= 1)
  {
    return a;
  }
  else
  {
    return a * RecPow(a, b - 1);
  }
}
long MyPow(int a, int b)
{
  if (b == 2)
  {
    return 4;
  }
  else
  {
    return MyPow(a, b / 2) * MyPow(a, b / 2);
  }
}
int numA = ReadData("Введите A: ");
int numB = ReadData("Введите B: ");
PrintData($"Число А, возведенное в степень B = {RecPow(numA, numB)}");
PrintData($"Число А, возведенное в степень B = {MyPow(numA, numB)}");